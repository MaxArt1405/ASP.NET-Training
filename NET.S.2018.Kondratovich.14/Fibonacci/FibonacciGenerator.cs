using System.Collections.Generic;
using System.Numerics;

namespace Fibonacci
{
    public class FibonacciGenerator
    {
        public static IEnumerable<BigInteger> GenerateFibonacci(int count)
        {
            BigInteger first = 0;
            BigInteger second = 1;

            BigInteger NextNumber()
            {
                var nextNumber = first + second;
                first = second;
                second = nextNumber;
                return nextNumber;
            }

            for (int i = 0; i < count; i++)
            {
                yield return first;
                NextNumber();
            }
        }
    }
}
