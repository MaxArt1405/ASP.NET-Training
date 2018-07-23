using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciGenerator
    {
       /* public static IEnumerable<int> GenerateFibonacci(int count)
        {
            int first = 0;
            int second = 1;

            int NextStep(int firstNumber, int secondNumber)
            {
                var nextNumber = first + second;
                first = second;
                second = nextNumber;
                return nextNumber;
            }

            for (int i = 0; i < count; i++)
            {
                yield return first;
                NextStep(first, second);
            }
        }*/
        public static IEnumerable<int> GenerateFibonacci()
        {
            int first = 0;
            int second = 1;

            int NextNumber()
            {
                var nextNumber = first + second;
                first = second;
                second = nextNumber;
                return nextNumber;
            }

            for (int i = 0; i < int.MaxValue - second; i++)
            {
                yield return first;
                NextNumber();
            }
        } 
         
    }
}
