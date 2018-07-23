using System;
using System.Collections.Generic;

namespace BinarySearchParametrized
{
    public class BinarySearch
    {
        public static int? Search<T>(T[] array, T element)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }

            if (Comparer<T>.Default == null)
            {
                throw new ArithmeticException($"{nameof(element)} must implementation IComparer");
            }

            return BinarySearchProcess(array, element, Comparer<T>.Default, 0, array.Length - 1);
        }

        private static int? BinarySearchProcess<T>(T[] array, T element, Comparer<T> comparer, int start, int end)
        {
            while (start <= end)
            {
                int middle = start + ((end - start) >> 1);
                int resultCompare = comparer.Compare(array[middle], element);

                if (resultCompare == 0)
                {
                    return middle;
                }
                if (resultCompare > 0)
                {
                    end = middle - 1;
                }
                if (resultCompare < 0)
                {
                    start = middle + 1;
                }
            }
            return null;
        }
    }
}
