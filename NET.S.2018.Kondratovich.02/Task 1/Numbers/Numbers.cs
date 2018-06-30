using System;

namespace Numbers
{
    /// <summary>
    /// Class for inserting numbers
    /// </summary>
    public static class Numbers
    {
        private static readonly int MaxInt = 0x7fffffff;
        private static readonly int QuantityOfBits = 31;
        /// <summary>
        /// This method performs insertation bits from second to first stsrting from startPosition to endPosition
        /// </summary>
        /// <param name="first">first number</param>
        /// <param name="second">second number</param>
        /// <param name="startPosition">Start position to insert bits</param>
        /// <param name="endPosition">End position to insert bits</param>
        /// <returns></returns>
        public static int Insertion(int first, int second, int startPosition, int endPosition)
        {
            CheckPosition(startPosition, endPosition);

            int secondNumber = MaxInt >> QuantityOfBits - (endPosition - startPosition + 1);
            secondNumber &= second;
            secondNumber <<= startPosition;

            int left = MaxInt << (endPosition + 1);
            left &= first;

            int right = MaxInt >> QuantityOfBits - startPosition;
            right &= first;

            return left ^ secondNumber ^ right;

        }
        /// <summary>
        /// This method checks positions for start and end position ofelements
        /// </summary>
        /// <param name="startPosition">Start position to insert bits</param>
        /// <param name="endPosition">End position to insert bits</param>
        private static void CheckPosition(int startPosition, int endPosition)
        {
            if (startPosition < 0 || startPosition > QuantityOfBits)
            {
                throw new ArgumentOutOfRangeException($"The position of {nameof(startPosition)} is incorrect");
            }

            if (endPosition < 0 || endPosition > QuantityOfBits)
            {
                throw new ArgumentOutOfRangeException($"The position of {nameof(endPosition)} is incorrect");
            }

            if (endPosition < startPosition)
            {
                throw new ArgumentException($"The position of {nameof(endPosition)} less than {nameof(startPosition)}");
            }
        }
    }
}
