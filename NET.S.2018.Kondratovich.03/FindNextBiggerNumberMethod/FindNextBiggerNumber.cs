using System;

namespace FindNextBiggerNumberMethod
{
    public class FindNextBiggerNumber
    {
        /// <summary>
        /// Find the closest number that greater than input number that contains only digits.
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns></returns>
        public static int FindingNextBiggerNumber(int number)
        {
            Valid(number);
            int[] arrDigits = ConvertIntToDigitArray(number);

            bool hasFound = false;
            int size = 0;
            int indexStartPoint = arrDigits.Length - 1;

            while (!hasFound && size < arrDigits.Length - 1)
            {
                for (int k = indexStartPoint; k >= indexStartPoint - size; k--)
                {
                    if (arrDigits[k] > arrDigits[indexStartPoint - size - 1])
                    {
                        Swap(ref arrDigits[k], ref arrDigits[indexStartPoint - size - 1]);
                        hasFound = true;
                        break;
                    }
                }
                size++;
            }
            if (!hasFound)
            {
                return -1;
            }
            if (size > 1)
            {
                return DeconvertDigitArrayToInt(Quicksort(arrDigits, --size, arrDigits.Length - 1));
            }
            return DeconvertDigitArrayToInt(arrDigits);
        }
        /// <summary>
        /// Converting int number to int[] array
        /// </summary>
        /// <param name="number">Int number</param>
        /// <returns></returns>
        private static int[] ConvertIntToDigitArray(int number)
        {
            string numberStr = Convert.ToString(number);

            int[] resultArray = new int[numberStr.Length];

            for (int i = 0; i < numberStr.Length; i++)
            {
                resultArray[i] = int.Parse(numberStr[i].ToString());
            }

            return resultArray;
        }
        /// <summary>
        /// Deconvert int[] array to int number
        /// </summary>
        /// <param name="arrDigit">Int[] array of digits</param>
        /// <returns></returns>
        private static int DeconvertDigitArrayToInt(int[] arrDigit)
        {

            int resultArray = Convert.ToInt32(string.Concat(arrDigit));
            return resultArray;
        }
        /// <summary>
        /// Quick sorting method
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="left">first array element</param>
        /// <param name="right">last array element</param>
        /// <returns></returns>
        private static int[] Quicksort(int[] array, int left, int right)
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
                return Quicksort(array, left, j);
            }
            if (i < right)
            {
                return Quicksort(array, i, right);
            }
            return array;
        }
        /// <summary>
        /// Swap two ref elements
        /// </summary>
        /// <param name="a">first element</param>
        /// <param name="b">second element</param>
        private static void Swap(ref int a, ref int b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }
        /// <summary>
        /// Checking method for input int number
        /// </summary>    
        /// <exception cref="ArgumentException">Throws when number less or equal zero.</exception>
        /// <param name="number">Int number</param>
        private static void Valid(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"The number {nameof(number)} must be positive number");
            }
            if (number == 0)
            {
                throw new ArgumentException($"The number {nameof(number)} can not be zero");
            }
        }
    }
}
