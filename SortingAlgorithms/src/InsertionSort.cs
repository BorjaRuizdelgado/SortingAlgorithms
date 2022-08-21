using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.src
{
    //radix sort is a non-comparative sorting algorithm.
    //It avoids comparison by creating and distributing elements into buckets according to their radix.
    //For elements with more than one significant digit, this bucketing process is repeated for each digit,
    //while preserving the ordering of the prior step, until all digits have been considered.
    public class InsertionSort : SortingAlgorithm
    {
        public void Sort(int[] array)
        {
            InsertionSortAlgorithm(array);
        }

        private static void InsertionSortAlgorithm(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var item = array[i];
                var currentIndex = i;

                while (currentIndex > 0 && array[currentIndex - 1] > item)
                {
                    array[currentIndex] = array[currentIndex - 1];
                    currentIndex--;
                }

                array[currentIndex] = item;
            }
        }
    }
}
