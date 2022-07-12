using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntraProcessInteraction
{
    public static class Data
    {
        public static int[] Generate(int amountOfData)
        {
            var array = new int[amountOfData];
            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(1, 10);
            }

            return array;
        }
    }
}
