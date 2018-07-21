using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciGenerator
    {
        public static IEnumerable<int> GenerateFibonacci(int count)
        {
            int first = 0;
            int second = 1;

            for(int i = 0; i < count; i++)
            {
                yield return first;
                NextStep(ref first, ref second);
            }
        }
        private static int NextStep(ref int first,ref int second)
        {
            var nextNumber = first + second;
            first = second;
            second = nextNumber;
            return nextNumber;
        }
    }
}
