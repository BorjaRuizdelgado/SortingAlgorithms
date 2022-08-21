
namespace SortingAlgorithms.src
{
    //radix sort is a non-comparative sorting algorithm.
    //It avoids comparison by creating and distributing elements into buckets according to their radix.
    //For elements with more than one significant digit, this bucketing process is repeated for each digit,
    //while preserving the ordering of the prior step, until all digits have been considered.
    public class RadixSort : SortingAlgorithm
    {
        public void Sort(int[] array)
        {
            RadixSortAlgorithm(array);
        }

        public void RadixSortAlgorithm(int[] array)
        {
            
            int[] temporary = new int[array.Length];

            // number of bits per group 
            int r = 4; 

            //Number of bits int32
            int b = 32;

            int[] count = new int[1 << r];
            int[] pref = new int[1 << r];
 
            int groups = (int)Math.Ceiling((double)b/r);

            
            int mask = (1 << r) - 1;

             
            for (int c = 0, shift = 0; c < groups; c++, shift += r)
            {
                
                for (int j = 0; j < count.Length; j++)
                    count[j] = 0;

                 
                for (int i = 0; i < array.Length; i++)
                    count[(array[i] >> shift) & mask]++;

                pref[0] = 0;
                for (int i = 1; i < count.Length; i++)
                    pref[i] = pref[i - 1] + count[i - 1];

                
                for (int i = 0; i < array.Length; i++)
                    temporary[pref[(array[i] >> shift) & mask]++] = array[i];

                
                temporary.CopyTo(array, 0);
            }
        }
    }
}
