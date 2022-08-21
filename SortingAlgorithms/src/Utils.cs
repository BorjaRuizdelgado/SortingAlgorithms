using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.src
{
    internal class Utils
    {

        public static int[] GetRandomArray(int length)
        {
            int Min = 0;
            int Max = int.MaxValue;
            Random randNum = new Random();
            int[] array = Enumerable
                        .Repeat(0, length)
                        .Select(i => randNum.Next(Min, Max))
                        .ToArray();

            return array;
        }
    }
}
