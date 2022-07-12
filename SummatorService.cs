using System;
using System.Diagnostics;
using System.Linq;

namespace IntraProcessInteraction
{
    public class SummatorService
    {
        private int[] _data;

        public SummatorService(int[] data)
        {
            _data = data;
        }

        public void Sum(ISummator summator)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int sum = summator.Sum(_data);

            stopwatch.Stop();

            Console.WriteLine($"{summator.GetType().Name}, Count elements={_data.Count()}, Sum={sum}, Total time={stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
