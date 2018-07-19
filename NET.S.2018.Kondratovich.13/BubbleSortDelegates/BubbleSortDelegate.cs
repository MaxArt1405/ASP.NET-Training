using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortDelegates
{
    public class BubbleSortDelegate
    {
        public static void SortRows(int[][] array, int[] keys, Comparison<int> comparator)
        {
            Validade(array, keys, comparator);
            InnerBubbleSortRows(array, keys, new DelegateComparer(comparator));
        }

        private static void InnerBubbleSortRows(int[][] items, int[] keys, IComparer<int> comparer)
        {
            bool isSort = false;

            for (int i = 0; i < keys.Length && !isSort; i++)
            {
                isSort = true;
                for (int j = 0; j < keys.Length - i - 1; j++)
                {
                    if (comparer.Compare(keys[j], keys[j + 1]) == 1)
                    {
                        SwapKeys(keys, j, j + 1);
                        SwapRows(items, j, j + 1);
                        isSort = false;
                    }
                }
            }
        }

        private static void SwapRows(int[][] array, int indexFirstRow, int indexSecondRow)
        {
            var temp = array[indexFirstRow];
            array[indexFirstRow] = array[indexSecondRow];
            array[indexSecondRow] = temp;
        }

        private static void SwapKeys(int[] keys, int indexFirstKey, int indexSecondKey)
        {
            int temp = keys[indexFirstKey];
            keys[indexFirstKey] = keys[indexSecondKey];
            keys[indexSecondKey] = temp;
        }
        private static void Validade(int[][] array, int[] keys, Comparison<int> comparator)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (keys == null)
            {
                throw new ArgumentNullException(nameof(keys));
            }

            if (comparator == null)
            {
                throw new ArgumentNullException(nameof(comparator));
            }
        }
    }
}
