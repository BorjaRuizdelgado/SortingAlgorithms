using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.src
{
    public class QuickSort : SortingAlgorithm
    {

        public void Sort(int[] array)
        {
           QuickSortAlgorithm(array, 0, array.Length - 1);
        }

        private static void QuickSortAlgorithm(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSortAlgorithm(arr, low, pi - 1);
                QuickSortAlgorithm(arr, pi + 1, high);
            }
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        private static int Partition(int[] arr, int right, int left)
        {
            int pivot = arr[left];
            int i = (right - 1);

            for (int j = right; j <= left - 1; j++)
            {

                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, left);
            return (i + 1);
        }


    }
}
