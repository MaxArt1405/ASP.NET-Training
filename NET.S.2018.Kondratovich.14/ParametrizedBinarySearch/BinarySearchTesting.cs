using System;
using BinarySearchParametrized;
using NUnit.Framework;

namespace BinarySearchTest
{
    [TestFixture]
    public class BinarySearchTesting
    {
        [Test]
        public void BinarySearchForElement_Success()
        {
            int[] number = { 0, 1, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26 };
            Assert.AreEqual(BinarySearch.Search(number, 14), 8);
        }
        [Test]
        public void BinarySearchInEmptyArray_Succed()
        {
            int[] number = { };
            Assert.AreEqual(BinarySearch.Search(number, 5), -1);
        }
        [Test]
        public void BinarySearchForElement_NotFound_Success()
        {
            int[] number = { 1, 2, 3, 4 };
            Assert.AreEqual(BinarySearch.Search(number, 5), -1);
        }
        [TestCase("ABCDEFGHIJKLMOPRSTUVWXYZ",'Z', ExpectedResult = 23)]
        [TestCase("ABCDEFGHIJKLMOPRSTUVWXYZ", 'k', ExpectedResult = 10)]
        [TestCase("ABCDEFGHIJKLMOPRSTUVWXYZ", 'B', ExpectedResult = 1)]
        [TestCase("ABCDEFGHIJKLMOPRSTUVWXYZ", 'w', ExpectedResult = 20)]
        public int BinarySearch_CustomComparer_Succed(string input, char item)
        {
            char[] str = input.ToCharArray();
            return BinarySearch.Search(str, char.ToUpper(item));
        }
    }
}
