using System;

namespace DoubleToBits
{
    public static class DoubleToBitString
    {
        private const int LengthDoubleOrder = 11;
        private const int LengthDoubleMantissa = 52;
        private const int RightOffsetDouble = 1023;
        private const int LeftOffsetDouble = -1022;
        private const int positiveBit = 1;
        private const int negativeBit = 0;

        /// <summary>
        /// This method gives Bit reprezentation of double value
        /// </summary>
        /// <param name="value">Input value</param>
        /// <returns></returns>
        public static string ToBitsString(this double value)
        {
            int sign = GetSignBit(value);

            if(sign == 1)
            {
                value = Math.Abs(value);
            }

            int order = GetOrder(value);
            int[] orderBinary = IntToBinaryArray(order, LengthDoubleOrder);
            int[] mantissaBinary = GetMantissaBinaryArray(GetMantissa(value, order));

            return GetBinaryRepresentation(sign, orderBinary, mantissaBinary);
        }
        /// <summary>
        /// Calculating an order of a double value 
        /// </summary>
        /// <param name="value">Input value</param>
        /// <returns></returns>
        private static int GetOrder(double value)
        {
            if (double.IsNaN(value))
            {
                return (int)Math.Pow(2, LengthDoubleOrder) - 1;
            }

            int order = 0;
            double fraction = (value / Math.Pow(2, order)) - 1;

            while ((fraction < 0) || (fraction >= 1))
            {
                if(fraction < 1.0)
                {
                    --order;
                }
                else
                {
                    ++order;
                }
                fraction = (value / Math.Pow(2, order)) - 1;
            }

            order += RightOffsetDouble;

            if(order < 0)
            {
                order = 0;
            }

            return order;
        }
        /// <summary>
        /// Method for finding mantissa of double value, according to IEEE 754
        /// </summary>
        /// <param name="value">Input value</param>
        /// <param name="order">Calculated order</param>
        /// <returns></returns>
        private static double GetMantissa(double value, int order)
        {
            if (double.IsNaN(value))
            {
                return Math.Pow(2, LengthDoubleMantissa);
            }

            order -= RightOffsetDouble;
            double mantissa = 0.0;

            if (order <= -RightOffsetDouble)
            {
                mantissa = value / Math.Pow(2, LeftOffsetDouble);
            }
            else
            {
                mantissa = (value / Math.Pow(2, order)) - 1;
            }

            return mantissa;
        }
        /// <summary>
        /// Convertation calculated mantissa into binary array
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static int[] GetMantissaBinaryArray(double value)
        {
            int[] result = new int[LengthDoubleMantissa];

            for (int i = 0; i < result.Length; i++)
            {
                value *= 2;
                if (value >= 1)
                {
                    result[i] = positiveBit;
                    value -= 1;
                }
                else
                {
                    result[i] = negativeBit;
                }
            }
            return result;
        }
        /// <summary>
        /// Calculating a sign(bit reprezentation)
        /// </summary>
        /// <param name="value">Input value</param>
        /// <returns></returns>
        private static int GetSignBit(double value)
        {
            int bit = 0;
            if (double.IsNegativeInfinity(1.0 / value) || value < 0.0)
            {
                bit = 1;
            }
            return bit;
        }
        /// <summary>
        /// Calculating and binary array compilation according to IEEE 754
        /// </summary>
        /// <param name="value">Input value</param>
        /// <param name="capacity">Capacity of array</param>
        /// <returns></returns>
        private static int[] IntToBinaryArray(int value, int capacity)
        {
            int[] result = new int[capacity];

            for (int i = 0; value != 0; value >>= 1, i++)
            {
                int bit;
                if((value & 1) == 1)
                {
                    bit = positiveBit;
                }
                else
                {
                    bit = negativeBit;
                }
                result[result.Length - i - 1] = bit;
            }

            return result;
        }
        /// <summary>
        /// Making answer from sign, order, mantissa
        /// </summary>
        /// <param name="sign">Binary sign of value</param>
        /// <param name="orderBinary">Binary reprezentation of an order</param>
        /// <param name="mantissaBinary">Binary reprezentation of an mantissa</param>
        /// <returns></returns>
        private static string GetBinaryRepresentation(int sign, int[] orderBinary, int[] mantissaBinary)
        {
            return string.Concat(sign, string.Concat(orderBinary), string.Concat(mantissaBinary));
        }
    }
}
