using System;

namespace SortingMethods
{
    /// <summary>
    /// Class for Quick and Merge sorting methods
    /// </summary>
    public static class Sortings
    {
        /// <summary>
        /// Quick sort for input array
        /// </summary>
        /// <param name="array">Non-sorted array</param>
        public static void QuickSorting(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"The value of parameter{nameof(array)} can't be null");
            }
            if(array.Length == 0)
            {
                throw new ArgumentException($"The length of {nameof(array)} can not be zero");
            }
            if (array.Length == 1)
            {
                returnSipleArray(array);
            }
            Quicksort(array, 0, array.Length - 1);
        }
        /// <summary>
        /// Merge sort for input array
        /// </summary>
        /// <param name="array">Non-sorted array</param>
        public static void MergeSorting(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"The value of parameter{nameof(array)} can't be null");
            }
            if (array.Length == 0)
            {
                throw new ArgumentException($"The length of {nameof(array)} can not be zero");
            }
            if (array.Length == 1)
            {
                returnSipleArray(array);
            }
            Mergesort(array, 0, array.Length - 1);
        }
        /// <summary>
        /// Realization of Quicksorting method
        /// </summary>
        /// <param name="array">Non-sorted array</param>
        /// <param name="left">first array element </param>
        /// <param name="right">last array element</param>
        private static void Quicksort(int[] array, int left, int right)
        {
            int i = left, j = right;
            int pivot = array[(left + right) / 2];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }
                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    Swap(ref array[i], ref array[j]);
                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                Quicksort(array, left, j);
            }
            if (i < right)
            {
                Quicksort(array, i, right);
            }
        }
        /// <summary>
        /// Realization for Mergesorting method
        /// </summary>
        /// <param name="input">Non-sorted array</param>
        /// <param name="low">first array element</param>
        /// <param name="high">last array element</param>
        private static void Mergesort(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                Mergesort(input, low, middle);
                Mergesort(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }
        /// <summary>
        /// Realization fir Merge
        /// </summary>
        /// <param name="array">Non-sorted array</param>
        /// <param name="low">first array element</param>
        /// <param name="middle">middle element</param>
        /// <param name="high">last array element</param>
        private static void Merge(int[] array, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (array[left] < array[right])
                {
                    tmp[tmpIndex] = array[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = array[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }
            while (left <= middle)
            {
                tmp[tmpIndex] = array[left];
                left = left + 1;
                tmpIndex = tmpIndex + 1;
            }
            while (right <= high)
            {
                tmp[tmpIndex] = array[right];
                right = right + 1;
                tmpIndex = tmpIndex + 1;
            }
            for (int i = 0; i < tmp.Length; i++)
            {
                array[low + i] = tmp[i];
            }
        }
        /// <summary>
        /// Swap two input elements
        /// </summary>
        /// <param name="a">first element</param>
        /// <param name="b">second element</param>
        private static void Swap(ref int a, ref int b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }
        private static int[] returnSipleArray(int[] array)
        {
            return array;
        }
    }
}
