using System;
namespace SortingAlgorithms.src
{
    //The Merge Sort algorithm is a sorting algorithm that is considered an example of the divide and conquer strategy.
    //So, in this algorithm, the array is initially divided into two equal halves and then they are combined in a sorted manner.
    //We can think of it as a recursive algorithm that continuously splits the array in half until it cannot be further divided.
    //This means that if the array becomes empty or has only one element left, the dividing will stop, i.e. it is the base case to stop the recursion.
    //If the array has multiple elements, we split the array into halves and recursively invoke the merge sort on each of the halves.
    //Finally, when both the halves are sorted, the merge operation is applied. Merge operation is the process of taking two smaller sorted arrays and combining them to eventually make a larger one.
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

