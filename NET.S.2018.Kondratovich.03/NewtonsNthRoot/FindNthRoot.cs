using System;

namespace NewtonsNthRoot
{
    public class FindNthRoot
    {
        /// <summary>
        /// Method for searching nth root of real nubmer by Newtons algorithm
        /// </summary>
        /// <param name="number">Input real number</param>
        /// <param name="root">root</param>
        /// <param name="eps">accurancy</param>
        /// <returns></returns>
        public static double SqrtN(double number, int root, double eps)
        {
            Valid(number, root, eps);

            double prev = number / root;
            double next = (1.0 / root) * ((root - 1) * prev + number / Pow(prev, root - 1));

            while (Math.Abs(next - prev) > eps)
            {
                prev = next;
                next = (1.0 / root) * ((root - 1) * prev + number / Pow(prev, root - 1));
            }

            return next;
        }
        /// <summary>
        /// Method for rizing in a power
        /// </summary>
        /// <param name="a">number</param>
        /// <param name="pow">power</param>
        /// <returns></returns>
        private static double Pow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= a;
            }
            return result;
        }
        /// <summary>
        /// Method for validating input parameters
        /// </summary>
        /// <param name="number">Real input number</param>
        /// <param name="root">root</param>
        /// <param name="eps">accurancy</param>
        private static void Valid(double number, int root, double eps)
        {
            if (root < 1)
            {
                throw new ArgumentException($"The {nameof(root)} can not be less than 1");
            }
            if (root % 2 == 0 && number < 0)
            {
                throw new ArgumentException($"It is impossible to extract {nameof(root)} from a negative {nameof(number)}");
            }
            if (eps < 0)
            {
                throw new ArgumentException($"The accurancy {nameof(eps)} can not be less than 0");
            }
        }
    }
}
