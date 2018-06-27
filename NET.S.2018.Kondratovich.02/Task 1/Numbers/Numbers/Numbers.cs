using System;

namespace Numbers
{
    public static class Numbers
    {
        private static readonly int maxInt = 0x7fffffff;
        private static readonly int quantityOfBits = 31;

        public static int Insertion(int first, int second, int startPosition, int endPosition)
        {
            CheckPosition(startPosition, endPosition);

            int SecondNumber = maxInt >> quantityOfBits - (endPosition - startPosition + 1);
            SecondNumber &= second;
            SecondNumber <<= startPosition;

            int Left = maxInt << (endPosition + 1);
            Left &= first;

            int Right = maxInt >> quantityOfBits - startPosition;
            Right &= first;

            return Left ^ SecondNumber ^ Right;

        }
        private static void CheckPosition(int startPosition, int endPosition)
        {
            if (startPosition < 0 || startPosition > 31)
            {
                throw new ArgumentOutOfRangeException($"The position of {nameof(startPosition)} is incorrect");
            }

            if (endPosition < 0 || endPosition > 31)
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
