using System;
namespace SortingAlgorithms.src
{
    public class MergeSort : SortingAlgorithm
    {
        public MergeSort()
        {
        }

        void SortingAlgorithm.Sort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                QuickSort(array, left, middle);
                QuickSort(array, middle + 1, right);
                MergeArray(array, left, middle, right);
            }
        }

        private void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];

            Array.Copy(array, left, leftTempArray, 0, leftArrayLength);
            Array.Copy(array, middle + 1, rightTempArray, 0, rightArrayLength);

            int i = 0;
            int j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }
            Array.Copy(leftTempArray, i, array, k, leftArrayLength - i);
            Array.Copy(rightTempArray, j, array, k, rightArrayLength - j);
           
        }
    }
}

