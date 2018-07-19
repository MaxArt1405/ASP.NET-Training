using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortDelegates
{
    public class RightHandedOrder : IComparer<int>
    {
        int IComparer<int>.Compare(int x, int y) => x.CompareTo(y);
    }
    public class LeftHandedOrder : IComparer<int>
    {
        int IComparer<int>.Compare(int x, int y) => y.CompareTo(x);
    }
    public static class BubbleSort
    {
        public static void SortRows(int[][] array, int[] keys, IComparer<int> comparer)
        {
            Validade(array, keys, comparer);
            InnerBubbleSortRows(array, keys, comparer.Compare);
        }

        private static void InnerBubbleSortRows(int[][] items, int[] keys, Comparison<int> comparison)
        {
            bool flag = false;

            for (int i = 0; i < keys.Length && !flag; i++)
            {
                flag = true;
                for (int j = 0; j < keys.Length - i - 1; j++)
                {
                    if (comparison(keys[j], keys[j + 1]) == 1)
                    {
                        SwapKeys(keys, j, j + 1);
                        SwapRows(items, j, j + 1);
                        flag = false;
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
        private static void Validade(int[][] array, int[] keys, IComparer<int> comparer)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (keys == null)
            {
                throw new ArgumentNullException(nameof(keys));
            }

            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }
        }
    }
}
