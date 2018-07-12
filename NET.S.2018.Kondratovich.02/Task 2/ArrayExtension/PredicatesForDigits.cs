using System;

namespace ArrayExtensions
{
    /// <summary>
    /// Class for searching criteria
    /// </summary>
    public class PredicateDigit
    {
        private int _digit;
        /// <summary>
        /// Constructor with one parameter
        /// </summary>
        /// <param name="digit">Searching digit</param>
        public PredicateDigit(int digit)
        {
            _digit = digit;
        }
        /// <summary>
        /// Method for answer(is there this digit)
        /// </summary>
        /// <param name="number">Input number</param>
        /// <returns></returns>
        public bool IsDigit(int number)
        {
            if (_digit != 0)
            {
                while (number != 0)
                {
                    int t = number % 10;
                    if (t == _digit)
                    {
                        return true;
                    }
                    number /= 10;
                }
            }
            else
            {
                if (number == 0 || number % 10 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
