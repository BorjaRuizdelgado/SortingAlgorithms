using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.src
{
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
