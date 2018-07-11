using System;
using System.Runtime.InteropServices;
using System.Text;

namespace DoubleToBits
{
    /// <summary>
    /// Converts double into binary string
    /// </summary>
    public static class DoubleToBitString
    {
        private const int BitsInByte = 8;
        private const int BitsInLong = BitsInByte * 8;
        /// <summary>
        /// Converts double number into bit representation.
        /// </summary>
        /// <param name="number">Double number to converting.</param>
        /// <returns>String of bits.</returns>
        public static string ConvertToString(this double number)
        {
            NumberUnion union = new NumberUnion(number);
            return union.ToLong().Convertation();
        }
        /// <summary>
        /// Makes string reprezentation
        /// </summary>
        /// <param name="union">Long number</param>
        /// <returns></returns>
        private static string Convertation(this long union)
        {
            string res = String.Empty;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 64; i++)
            {
                result.Insert(0,((union & 1) == 1) ? "1" : "0");
                union >>= 1;
            }
            return result.ToString();
        }
        [StructLayout(LayoutKind.Explicit)]
        private struct NumberUnion
        {
            [FieldOffset(0)]
            private readonly double DNumber;
            [FieldOffset(0)]
            private readonly long LNumber;

            public NumberUnion(double value) : this()
            {
                DNumber = value;
            }

            public long ToLong() => LNumber;
        }
    }
}
