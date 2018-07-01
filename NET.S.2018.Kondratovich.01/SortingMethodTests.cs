using System;
using SortingMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestForMergeAndQuickSorts
{
    [TestClass]
    public class UnitTestForMergeSorting
    {
        [TestMethod]
        public void Sorting_Array_By_MergeSort_Success()
        {
            int[] actual = new int[] { 5, 8, -1, 4, 6, -2, 9, 7, 1, -3, 3, 2, 0 };
            int[] expected = new int[] { -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Sortings.MergeSorting(actual);
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MergeSort_With_Throwing_ArgumentNullException()
        {
            int[] actual = null;
            Sortings.MergeSorting(actual);
        }
        [TestMethod]
        public void Sorting_Array_By_Mergesort_In_Huge_Size()
        {
            Random rnd = new Random();
            int[] actual = new int[10000000];
            int[] expected = actual;
            for(int i = 0; i < actual.Length; i++)
            {
                actual[i] = rnd.Next();
            }
            Sortings.MergeSorting(actual);
            CollectionAssert.AreEqual(actual, expected);
        }
    }
    [TestClass]
    public class UnitTestsForQuickSorting
    {
        [TestMethod]
        public void Sorting_Array_By_QuickSort_Success()
        {
            int[] actual = new int[] { 5, 8, -1, 4, 6, -2, 9, 7, 1, -3, 3, 2, 0 };
            int[] expected = new int[] { -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Sortings.QuickSorting(actual);
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSort_With_Throwing_ArgumentNullException()
        {
            int[] actual = null;
            Sortings.MergeSorting(actual);
        }
        [TestMethod]
        public void Sorting_Array_By_Quicksort_In_Huge_Size()
        {
            Random rnd = new Random();
            int[] actual = new int[10000000];
            int[] expected = actual;
            for (int i = 0; i < actual.Length; i++)
            {
                actual[i] = rnd.Next();
            }
            Sortings.QuickSorting(actual);
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Sorting_SipleArray_Success()
        {
            int[] actual = { 1 };
            int[] expected = { 1 };
            Sortings.QuickSorting(actual);
            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
