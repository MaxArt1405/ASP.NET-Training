using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayExtensions;

namespace ArrayExtensionTests
{
    [TestClass]
    public class ArrayExtensionTest
    {
        [TestMethod]
        public void FilterNumbers_WithDigit0_Success()
        {
            int[] array = new int[] { 1, 10, 5, 15, 20, 58, 60 };
            PredicateDigit0 digit = new PredicateDigit0();
            int[] expected = new int[] { 10, 20, 60 };
            int[] actual = ArrayExtension.FilterNumbers(array, digit);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit1_Success()
        {
            int[] array = new int[] { 1, 2, 5, 10, 4, 11 };
            PredicateDigit1 digit = new PredicateDigit1();
            int[] expected = new int[] { 1, 10, 11 };
            int[] actual = ArrayExtension.FilterNumbers(array, digit);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit2_Success()
        {
            int[] array = new int[] { 2, 4, 6, 8, 10, 12 };
            PredicateDigit2 digit = new PredicateDigit2();
            int[] expected = new int[] { 2, 12 };
            int[] actual = ArrayExtension.FilterNumbers(array, digit);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit3_Success()
        {
            int[] array = new int[] { 1, 2, 3, 6, 13 };
            PredicateDigit3 digit = new PredicateDigit3();
            int[] expected = new int[] { 3, 13 };
            int[] actual = ArrayExtension.FilterNumbers(array, digit);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit4_Success()
        {
            int[] array = new int[] { 1, 2, 4, 8, 14, 24 };
            PredicateDigit4 digit = new PredicateDigit4();
            int[] expected = new int[] { 4, 14, 24 };
            int[] actual = ArrayExtension.FilterNumbers(array, digit);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit5_Success()
        {
            int[] array = new int[] { 51, 2, 5, 7, 751 };
            PredicateDigit5 digit = new PredicateDigit5();
            int[] expected = new int[] { 51, 5, 751 };
            int[] actual = ArrayExtension.FilterNumbers(array, digit);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit6_Success()
        {
            int[] array = new int[] { 1, 2, 6, 12, 16, 26 };
            PredicateDigit6 digit = new PredicateDigit6();
            int[] expected = new int[] { 6, 16, 26 };
            int[] actual = ArrayExtension.FilterNumbers(array, digit);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit7_Success()
        {
            int[] array = new int[] { 2, 7, 14, 27, 52, 77  };
            PredicateDigit7 digit = new PredicateDigit7();
            int[] expected = new int[] { 7, 27, 77 };
            int[] actual = ArrayExtension.FilterNumbers(array, digit);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit8_Success()
        {
            int[] array = new int[] { 1, 5, 8, 15, 18 };
            PredicateDigit8 digit = new PredicateDigit8();
            int[] expected = new int[] { 8, 18 };
            int[] actual = ArrayExtension.FilterNumbers(array, digit);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilterNumbers_WithDigit9_Success()
        {
            int[] array = new int[] { 1, 4, 8, 9, 15, 19 };
            PredicateDigit9 digit = new PredicateDigit9();
            int[] expected = new int[] { 9, 19 };
            int[] actual = ArrayExtension.FilterNumbers(array, digit);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FilterNumbers_WithEmptyArgument_ThrowArgumentException()
        {
            int[] array = new int[] { };
            PredicateDigit0 digit = new PredicateDigit0();
            int[] actual = ArrayExtension.FilterNumbers(array, digit);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FilterNumbers_WithNullArgument_ThrowArgumentNulException()
        {
            int[] array = null;
            PredicateDigit0 digit = new PredicateDigit0();
            int[] actual = ArrayExtension.FilterNumbers(array, digit);
        }

    }
}
   