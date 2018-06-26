using System;

namespace QuickSort
{
    public static class QuickSort
    {
        public static int[] QuickSorting(this int[] array)
        {
            if(array == null)
            {
                throw new ArgumentNullException($"The value of parameter{nameof(array)} can't be null");
            }
            if(array.Length == 0)
            {
                throw new ArgumentException($"The total length of {nameof(array)} can't be zero");
            }
            return Quicksort(array, 0, array.Length-1);
        }
        public static int[] Quicksort(int[] array, int left, int right)
        {
            int i = left, j = right;
            int pivot = array[(left + right) / 2];
            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (array[j].CompareTo(pivot) > 0)
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
            return array;
        }
        private static void Swap(ref int a, ref int b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }
    }
}
