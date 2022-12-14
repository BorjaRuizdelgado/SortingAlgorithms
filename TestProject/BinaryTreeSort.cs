using SortingAlgorithms.src;
using SortingAlgorithmsTests.utils;

namespace Tests
{
    public class BinaryTreeSortTests
    {
        [Test]
        public void ShouldBinaryTreeSortCorrectly()
        {
            int[] array = Utils.GetRandomArray(100);
            int[] array2 = new int[array.Length];
            Array.Copy(array, array2, array.Length);

            SortingAlgorithm algorithm = new BinaryTreeSort();
            algorithm.Sort(array);

            Assert.That(array2.Length, Is.EqualTo(array.Length));

            foreach (int i in array)
            {
                Assert.IsTrue(array2.Contains(i));
            }

            Array.Sort(array2);

            CollectionAssert.AreEqual(array, array2);
        }
    }
}
