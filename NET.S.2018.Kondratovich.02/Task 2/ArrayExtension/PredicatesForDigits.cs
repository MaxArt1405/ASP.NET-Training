using System;

namespace ArrayExtensions
{
    public class PredicateDigit
    {
        private int _digit;

        public PredicateDigit(int digit)
        {
            _digit = digit;
        }

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
