using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortDelegates
{
    public class SortKeys
    {
        public static int[] GetMinRowsElements(int[][] array)
        {
            Validate(array);
            int[] minRowsElements = new int[array.Length];
            int find = 0;

            for (int i = 0; i < array.Length; i++)
            {
                find = 0;
                for (int j = 1; j < array[i].Length; j++)
                {
                    if (array[i][find] > array[i][j])
                    {
                        find = j;
                    }
                }
                minRowsElements[i] = array[i].Length == 0 ? 0 : array[i][find];
            }
            return minRowsElements;
        }
        public static int[] GetMaxRowsElements(int[][] array)
        {
            Validate(array);
            int[] maxRowsElements = new int[array.Length];
            int find = 0;

            for (int i = 0; i < array.Length; i++)
            {
                find = 0;
                for (int j = 1; j < array[i].Length; j++)
                {
                    if (array[i][find] < array[i][j])
                    {
                        find = j;
                    }
                }
                maxRowsElements[i] = array[i].Length == 0 ? 0 : array[i][find];
            }
            return maxRowsElements;
        }
        public static int[] GetSumOfRowsElements(int[][] array)
        {
            Validate(array);
            int[] totalRows = new int[array.GetLength(0)];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
                totalRows[i] = sum;
            }
            return totalRows;
        }
        public static void Validate(int[][] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
        }
    }
}
