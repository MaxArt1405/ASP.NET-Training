using System;

namespace StringExtentionLibrary
{
    public static class StringExtention
    {
        private const int UpperValue = 16;
        private const int LowerValue = 2;
        /// <summary>
        /// Extention method to convert string presentation number in notation with base to decimal notation.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="notation">The notation.</param>
        public static long ToDecimalConverter(this string source, Notation notation)
        {
            Valid(source, notation);

            string alphabet = notation.Alphabet;
            string upperString = source.ToUpper();
            long number = 0, product = 1;
            int basis = notation.Basis;

            for (int i = source.Length - 1; i >= 0; i--)
            {
                checked
                {
                    if (ConvertToValue(upperString[i], alphabet) == -1)
                    {
                        throw new ArgumentException($"Invalid symbol {source[i]} in string!");
                    }
                    else
                    {
                        number += product * ConvertToValue(upperString[i], alphabet);
                        product *= basis;
                    }
                }
            }
            return number;
        }
        /// <summary>
        /// Convert char symbol to integer value as a position in "alphabet string".
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <param name="alphbet">The alphbet.</param>
        /// <returns></returns>
        private static int ConvertToValue(char symbol, string alphbet) => alphbet.IndexOf(symbol);
        /// <summary>
        /// Validating of input data
        /// </summary>
        /// <param name="source">Source</param>
        /// <param name="notation">Notation</param>
        /// <exception cref="ArgumentNullException">Throw when string is null or empty</exception>
        /// <exception cref="ArgumentNullException">Throw when notation is null</exception>
        /// <exception cref="OverflowException">Throw when basis is invalid</exception>
        /// <exception cref="OverflowException">Throw when length is larger then sizeof(int)</exception>
        private static void Valid(this string source, Notation notation)
        {
            if (notation == null)
            {
                throw new ArgumentNullException($"The object {nameof(notation)} can not be null!");
            }
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException($"The string {nameof(source)} can not be null or empty!");
            }
            if(notation.Basis < LowerValue || notation.Basis > UpperValue)
            {
                throw new OverflowException($"Base of Notation must be more then  and less or equal then !");
            }
            if(source.Length >= sizeof(int) * 8)
            {
                throw new OverflowException($"Length of { nameof(source) } should be less than 32!");
            }
        }
    }
}

