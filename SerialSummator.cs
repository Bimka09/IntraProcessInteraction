namespace IntraProcessInteraction
{
    class SerialSummator : ISummator
    {
        public int Sum(int[] data)
        {
            int sum = 0;
            foreach (int i in data)
            {
                sum += i;
            }

            return sum;
        }
    }
}
