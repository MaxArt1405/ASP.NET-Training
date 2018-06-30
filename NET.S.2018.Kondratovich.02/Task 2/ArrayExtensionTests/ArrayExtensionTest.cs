using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayExtensions;
using static ArrayExtensions.ArrayExtension;

namespace ArrayExtensionTests
{
    [TestClass]
    public class ArrayExtensionTest
    {
        [TestMethod]
        public void FilterNumbers_WithDigit0_Success()
        {
            int[] array = new int[] { 1, 10, 5, 15, 20, 58, 60 };
            int[] expected = new int[] { 10, 20, 60 };
            int[] actual = array.FilterNumbers(new PredicateDigit0());
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit1_Success()
        {
            int[] array = new int[] { 1, 2, 5, 10, 4, 11 };
            int[] expected = new int[] { 1, 10, 11 };
            int[] actual = array.FilterNumbers(new PredicateDigit1());
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit2_Success()
        {
            int[] array = new int[] { 2, 4, 6, 8, 10, 12 };
            int[] expected = new int[] { 2, 12 };
            int[] actual = array.FilterNumbers(new PredicateDigit2());
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit3_Success()
        {
            int[] array = new int[] { 1, 2, 3, 6, 13 };
            int[] expected = new int[] { 3, 13 };
            int[] actual = array.FilterNumbers(new PredicateDigit3());
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit4_Success()
        {
            int[] array = new int[] { 1, 2, 4, 8, 14, 24 };
            int[] expected = new int[] { 4, 14, 24 };
            int[] actual = array.FilterNumbers(new PredicateDigit4());
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit5_Success()
        {
            int[] array = new int[] { 51, 2, 5, 7, 751 };
            int[] expected = new int[] { 51, 5, 751 };
            int[] actual = array.FilterNumbers(new PredicateDigit5());
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit6_Success()
        {
            int[] array = new int[] { 1, 2, 6, 12, 16, 26 };
            int[] expected = new int[] { 6, 16, 26 };
            int[] actual = array.FilterNumbers(new PredicateDigit6());
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit7_Success()
        {
            int[] array = new int[] { 2, 7, 14, 27, 52, 77  };
            int[] expected = new int[] { 7, 27, 77 };
            int[] actual = array.FilterNumbers(new PredicateDigit7());
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit8_Success()
        {
            int[] array = new int[] { 1, 5, 8, 15, 18 };
            int[] expected = new int[] { 8, 18 };
            int[] actual = array.FilterNumbers(new PredicateDigit8());
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit9_Success()
        {
            int[] array = new int[] { 1, 4, 8, 9, 15, 19 };
            int[] expected = new int[] { 9, 19 };
            int[] actual = array.FilterNumbers(new PredicateDigit9());
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FilterNumbers_WithEmptyArgument_ThrowArgumentException()
        {
            int[] array = new int[] { };
            int[] actual = array.FilterNumbers(new PredicateDigit0());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FilterNumbers_WithNullArgument_ThrowArgumentNulException()
        {
            int[] array = null;
            int[] actual = array.FilterNumbers(new PredicateDigit0());
        }

    }
}
   