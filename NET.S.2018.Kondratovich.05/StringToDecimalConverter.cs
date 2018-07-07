using System;

namespace DecimalConverter
{
    public static class StringToDecimalConverter
    {
        /// <summary>
        /// Method for converting string to any notation from 2 to 16
        /// </summary>
        /// <param name="source">Input string</param>
        /// <param name="notation">The notation for converting</param>
        /// <returns></returns>
        public static int ConvertingToDecimal(this string source, Notation notation)
        {
            Valid(source, notation);
            return GetConvertedNumber(source, notation);
        }
        /// <summary>
        /// Method, which return converted string to recieved notation
        /// </summary>
        /// <param name="source">Input string</param>
        /// <param name="notation">The notation for converting</param>
        /// <returns></returns>
        private static int GetConvertedNumber(this string source, Notation notation)
        {
            int result = 0;
            for (int i = 0, j = source.Length - 1; i < source.Length; i++)
            {
                result += (int)Math.Pow(notation.Scale, j - i) * notation.Alphabet.IndexOf(source[i].ToString().ToUpper());
            }
            return result;
        }
        /// <summary>
        /// Method for validating input data
        /// </summary>
        /// <param name="source">Input string number</param>
        /// <param name="notation">The notation for converting</param>
        /// <exception cref="ArgumentNullException">Throws when input source is null or empty.</exception>    
        /// <exception cref="ArgumentException">Throws when scale of notation isn't from 2 to 16 .</exception>
        /// <exception cref="OverflowException">Throws when the source.Length is greater than capacity of Int32.</exception>
        private static void Valid(this string source, Notation notation)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentNullException($"{nameof(source)} is empty or null.");
            }
            if (notation.Scale < 2 || notation.Scale > 16)
            {
                throw new ArgumentException($"The {nameof(notation.Scale)} of an notation must be from 2 to 16.");
            }
            if (source.Length >= sizeof(int) * 8)
            {
                throw new OverflowException($"Length of {nameof(source)} should be less than 32!");
            }
        }
    }
}
