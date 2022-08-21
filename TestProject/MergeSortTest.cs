using SortingAlgorithmsTests.utils;
using SortingAlgorithms.src;
namespace Tests
{
    public class MergeSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldMergeSortCorrectly()
        {
            int[] array = Utils.GetRandomArray(100);
            int[] array2 = new int[array.Length];
            Array.Copy(array, array2, array.Length);

            SortingAlgorithm algorithm = new MergeSort();
            algorithm.Sort(array);

            Assert.That(array2.Length, Is.EqualTo(array.Length));

            foreach(int i in array)
            {
                Assert.IsTrue(array2.Contains(i));
            }

            Array.Sort(array2);

            CollectionAssert.AreEqual(array, array2);
        }
    }
}