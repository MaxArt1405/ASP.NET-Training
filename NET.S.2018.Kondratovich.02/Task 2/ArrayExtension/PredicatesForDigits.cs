using System;

namespace ArrayExtensions
{
    public class PredicateDigit0 : IPredicate<int>
    {
        public bool IsMatch(int number) => IsDigit(Math.Abs(number), 0);
        private static bool IsDigit(int number, int digit)
        {
            if (digit != 0)
            {
                while (number != 0)
                {
                    int t = number % 10;
                    if (t == digit)
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
    public class PredicateDigit1 : IPredicate<int>
    {
        public bool IsMatch(int number) => IsDigit(Math.Abs(number), 1);
        private static bool IsDigit(int number, int digit)
        {
            if (digit != 0)
            {
                while (number != 0)
                {
                    int t = number % 10;
                    if (t == digit)
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
    public class PredicateDigit2 : IPredicate<int>
    {
        public bool IsMatch(int number) => IsDigit(Math.Abs(number), 2);
        private static bool IsDigit(int number, int digit)
        {
            if (digit != 0)
            {
                while (number != 0)
                {
                    int t = number % 10;
                    if (t == digit)
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
    public class PredicateDigit3 : IPredicate<int>
    {
        public bool IsMatch(int number) => IsDigit(Math.Abs(number), 3);
        private static bool IsDigit(int number, int digit)
        {
            if (digit != 0)
            {
                while (number != 0)
                {
                    int t = number % 10;
                    if (t == digit)
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
    public class PredicateDigit4 : IPredicate<int>
    {
        public bool IsMatch(int number) => IsDigit(Math.Abs(number), 4);
        private static bool IsDigit(int number, int digit)
        {
            if (digit != 0)
            {
                while (number != 0)
                {
                    int t = number % 10;
                    if (t == digit)
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
    public class PredicateDigit5 : IPredicate<int>
    {
        public bool IsMatch(int number) => IsDigit(Math.Abs(number), 5);
        private static bool IsDigit(int number, int digit)
        {
            if (digit != 0)
            {
                while (number != 0)
                {
                    int t = number % 10;
                    if (t == digit)
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
    public class PredicateDigit6 : IPredicate<int>
    {
        public bool IsMatch(int number) => IsDigit(Math.Abs(number), 6);
        private static bool IsDigit(int number, int digit)
        {
            if (digit != 0)
            {
                while (number != 0)
                {
                    int t = number % 10;
                    if (t == digit)
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
    public class PredicateDigit7 : IPredicate<int>
    {
        public bool IsMatch(int number) => IsDigit(Math.Abs(number), 7);
        private static bool IsDigit(int number, int digit)
        {
            if (digit != 0)
            {
                while (number != 0)
                {
                    int t = number % 10;
                    if (t == digit)
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
    public class PredicateDigit8 : IPredicate<int>
    {
        public bool IsMatch(int number) => IsDigit(Math.Abs(number), 8);
        private static bool IsDigit(int number, int digit)
        {
            if (digit != 0)
            {
                while (number != 0)
                {
                    int t = number % 10;
                    if (t == digit)
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
    public class PredicateDigit9 : IPredicate<int>
    {
        public bool IsMatch(int number) => IsDigit(Math.Abs(number), 9);
        private static bool IsDigit(int number, int digit)
        {
            if (digit != 0)
            {
                while (number != 0)
                {
                    int t = number % 10;
                    if (t == digit)
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
    public class PredicatePosistiveNumber : IPredicate<int>
    {
        public bool IsMatch(int number) => number > 0;
    }
    public class PredicateStringLength : IPredicate<string>
    {
        public bool IsMatch(string number) => number.Length > 0;
    }
}
