using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchParametrized
{
    public class BinarySearch
    {
        /// <summary>
        /// Search element in T[]array by binary search.
        /// To compare elements use <see cref="Comparer<T>"/>
        /// </summary>
        /// <param name="array">Array to search in.</param>
        /// <param name="element">Element to search.</param>
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="array"/> is null.
        /// If <paramref name="element"/> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// If T-type does not impelemnts <see cref="IComparer{T}"/>.
        /// </exception>
        /// <returns>Found index. If element not found then return -1.</returns>
        public static int Search<T>(T[] array, T element)
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

            return InnerBinarySearch(array, element, Comparer<T>.Default, 0, array.Length - 1);
        }

        private static int InnerBinarySearch<T>(T[] array, T element, Comparer<T> comparer, int start, int end)
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
            return -1;
        }
    }
}
