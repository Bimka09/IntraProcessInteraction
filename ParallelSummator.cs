using System.Linq;

namespace IntraProcessInteraction
{
    class ParallelSummator : ISummator
    {
        public int Sum(int[] data)
        {
            return data.AsParallel().Sum();
        }
    }
}
