using System;

namespace IntraProcessInteraction
{
    internal class Program
    {
        static int[] dataCount = new int[] { 100_000, 1_000_000, 10_000_000 };
        static void Main(string[] args)
        {
            foreach (int count in dataCount)
            {
                var data = Data.Generate(count);
                SummatorService summatorService = new SummatorService(data);
                summatorService.Sum(new SerialSummator());
                summatorService.Sum(new ThreadSummator());
                summatorService.Sum(new ParallelSummator());
            }
        }
    }
}
