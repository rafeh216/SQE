using Xunit;
using SearchAlgorithms;

namespace SearchAlgorithms.Tests
{
    public class BinarySearchTests
    {
        private readonly BinarySearch _binarySearch;

        public BinarySearchTests()
        {
            _binarySearch = new BinarySearch();
        }

        [Fact]
        public void Search_TargetAtMiddle_ReturnsIndex()
        {

            int[] array = { 1, 3, 5, 7, 9 };
            int result = _binarySearch.Search(5, array);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Search_TargetInLowerHalf_ReturnsIndex()
        {

            int[] array = { 1, 3, 5, 7, 9 };
            int result = _binarySearch.Search(7, array);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Search_TargetInUpperHalf_ReturnsIndex()
        {

            int[] array = { 1, 3, 5, 7, 9 };
            int result = _binarySearch.Search(3, array);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Search_TargetNotFound_ReturnsMinusOne()
        {

            int[] array = { 1, 3, 5, 7, 9 };
            int result = _binarySearch.Search(4, array);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_EmptyArray_ReturnsMinusOne()
        {

            int[] array = { };
            int result = _binarySearch.Search(5, array);
            Assert.Equal(-1, result);
        }
    }
}