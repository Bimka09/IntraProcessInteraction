using System.Linq;
using System.Threading;

namespace IntraProcessInteraction
{
    class ThreadSummator : ISummator
    {
        CountdownEvent _countdownEvent;
        int _countThreads = 4;
        object _lock = new object();
        int _sum;

        public int Sum(int[] data)
        {
            _countdownEvent = new CountdownEvent(_countThreads);

            _sum = 0;

            for (int i = 0; i < _countThreads; i++)
            {
                ThreadPool.QueueUserWorkItem(StartHandlerThread, data.Where((_, ind) => ind % _countThreads == i).ToArray());
            }

            _countdownEvent.Wait();

            return _sum;
        }

        private void StartHandlerThread(object obj)
        {
            int[] data = (int[])obj;

            int sum = 0;
            foreach (int i in data)
            {
                sum += i;
            }

            lock (_lock)
            {
                _sum += sum;
            }
            _countdownEvent.Signal();
        }
    }
}
