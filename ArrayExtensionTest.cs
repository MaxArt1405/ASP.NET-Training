using System;
using NUnit.Framework;
using ArrayExtensions;
using static ArrayExtensions.ArrayExtension;

namespace ArrayExtensionTests
{
    [TestFixture]
    public class ArrayExtensionTest
    {
        [TestCase(0, new int[] { 1, 10, 8, 20, 11, 60}, ExpectedResult = new [] { 10, 20, 60 })]
        [TestCase(1, new int[] { 1, 2, 5, 10, 4, 11 }, ExpectedResult = new[] { 1, 10, 11 })]
        [TestCase(2, new int[] { 1, 2, 5, 8, 12, 45 }, ExpectedResult = new[] { 2, 12 })]
        [TestCase(3, new int[] { 1, 2, 3, 6, 13 }, ExpectedResult = new[] { 3, 13 })]
        [TestCase(4, new int[] { 1, 2, 4, 8, 14, 24 }, ExpectedResult = new[] { 4, 14, 24 })]
        [TestCase(5, new int[] { 51, 2, 5, 7, 751 }, ExpectedResult = new[] { 51, 5, 751 })]
        [TestCase(6, new int[] { 1, 2, 6, 12, 16, 26 }, ExpectedResult = new[] { 6, 16, 26 })]
        [TestCase(7, new int[] { 2, 7, 14, 27, 52, 77 }, ExpectedResult = new[] { 7, 27, 77 })]
        [TestCase(8, new int[] { 1, 5, 8, 15, 18 }, ExpectedResult = new[] { 8, 18 })]
        [TestCase(9, new int[] { 1, 4, 8, 9, 15, 19 }, ExpectedResult = new[] { 9, 19 })]
        public int[] FilterNumbers_WithDigit0_Success(int digit, int[] array )
        {
            int[] actual = array.FilterNumbers(new PredicateDigit(digit));
            return actual;
        }
        [Test]
        public void FilterNumbers_ThrowsNullArgumentException()
        {
            int digit = 1;
            int[] actual = null;
            Assert.Throws<ArgumentNullException>(() => actual.FilterNumbers(new PredicateDigit(digit)));
        }
    }
}