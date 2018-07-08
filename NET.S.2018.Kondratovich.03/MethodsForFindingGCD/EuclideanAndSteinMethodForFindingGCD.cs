using System;

namespace MethodsForFindingGCD
{
    /// <summary>
    /// Class contains methods to find GCD by Euclidean and Stein algorithms
    /// </summary>
    public class EuclideanAndSteinMethodForFindingGCD
    {
        /// <summary>
        /// Euclidean method for two parameters
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <returns></returns>
        public static int EuclideanMethod(int firstNumber, int secondNumber)
        {
            return QuickSolutionForEuclid(firstNumber, secondNumber);
        }
        /// <summary>
        /// Euclidean method for two and more parameters
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <param name="numbers">Array of numbers without first and second</param>
        /// <returns></returns>
        public static int EuclideanMethod(int firstNumber, int secondNumber, params int[] numbers)
        {
            Valid(numbers);
            int result = QuickSolutionForEuclid(firstNumber, secondNumber);
     
            for(int i = 0; result != 1 && i < numbers.Length; i++)
            {
                result = QuickSolutionForEuclid(result, numbers[i]);
            }
            return result;
        }
        /// <summary>
        /// Computing the greatest common divisor with time by Euclid's algorithm.
        /// </summary>
        /// <param name="time">The out parameter to compute lead time.</param>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns></returns>
        public static int EuclideanMethod(out TimeSpan time, int firstNumber, int secondNumber)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = EuclideanMethod(firstNumber, secondNumber);
            stopwatch.Stop();
            time = stopwatch.Elapsed;

            return result;
        }
        /// <summary>
        /// Computing the greatest common divisor with time by Euclid's algorithm with any count of parameters.
        /// </summary>
        /// <param name="time">The out parameter to compute lead time.</param>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns></returns>
        public static int EuclideanMethod(out TimeSpan time, int firstNumber, int secondNumber, params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = EuclideanMethod(firstNumber, secondNumber, numbers);
            stopwatch.Stop();
            time = stopwatch.Elapsed;

            return result;
        }
        /// <summary>
        /// Stein method for two parameters
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <returns></returns>
        public static int SteinMethod(int firstNumber, int secondNumber)
        {
            return QuickSolutionForStein(firstNumber, secondNumber);
        }
        /// <summary>
        /// Stein method for two and more parameters
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <param name="numbers">Array of numbers without first and second</param>
        /// <returns></returns>
        public static int SteinMethod(int firstNumber, int secondNumber, params int[] numbers)
        {
            Valid(numbers);
            int result = QuickSolutionForStein(firstNumber, secondNumber);

            for (int i = 0; result != 1 && i < numbers.Length; i++)
            {
                result = QuickSolutionForStein(result, numbers[i]);
            }
            return result;
        }
        /// <summary>
        /// Computing the greatest common divisor with time by Steins's algorithm.
        /// </summary>
        /// <param name="time">The out parameter to compute lead time.</param>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns></returns>
        public static int SteinMethod(out TimeSpan time, int firstNumber, int secondNumber)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = SteinMethod(firstNumber, secondNumber);
            stopwatch.Stop();
            time = stopwatch.Elapsed;

            return result;
        }
        /// <summary>
        /// Computing the greatest common divisor with time by Stein's algorithm with any count of parameters.
        /// </summary>
        /// <param name="time">The out parameter to compute lead time.</param>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns></returns>
        public static int SteinMethod(out TimeSpan time, int firstNumber, int secondNumber, params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int result = SteinMethod(firstNumber, secondNumber, numbers);
            stopwatch.Stop();
            time = stopwatch.Elapsed;

            return result;
        }
        /// <summary>
        /// Realization of Euclid GCD algorithm
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <returns></returns>
        private static int EuclideanMethodEvaluation(int firstNumber, int secondNumber)
        {
            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);
            
            while (firstNumber != secondNumber)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber -= secondNumber;
                }
                else
                {
                    secondNumber -= firstNumber;
                }
            }
            return firstNumber;
        }
        /// <summary>
        /// Realization of Stein GCD algorithm
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <returns></returns>
        private static int SteinMethodEvaluation(int firstNumber, int secondNumber)
        {
            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);
            if (firstNumber == secondNumber)
            {
                return firstNumber;
            }
            if ((~firstNumber & 1) != 0)
            {
                if ((secondNumber & 1) != 0)
                {
                    return SteinMethodEvaluation(firstNumber >> 1, secondNumber);
                }
                else
                {
                    return SteinMethodEvaluation(firstNumber >> 1, secondNumber >> 1) << 1;
                }
            }
            if ((~secondNumber & 1) != 0)
            {
                return SteinMethodEvaluation(firstNumber, secondNumber >> 1);
            }

            if (firstNumber > secondNumber)
            {
                return SteinMethodEvaluation((firstNumber - secondNumber) >> 1, secondNumber);
            }
            return SteinMethodEvaluation((secondNumber - firstNumber) >> 1, firstNumber);
        }
        /// <summary>
        /// Quick solution for Euclid Method(if one of the numbers equals zero, it's useless to evaluate)
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <returns></returns>
        private static int QuickSolutionForEuclid(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0)
            {
                return Math.Abs(secondNumber);
            }
            if(secondNumber == 0)
            {
                return Math.Abs(firstNumber);
            }  
            return EuclideanMethodEvaluation(firstNumber, secondNumber);
        }
        /// <summary>
        /// Quick solution for Stein Method(if one of the numbers equals zero, it's useless to evaluate)
        /// </summary>
        /// <param name="firstNumber">First number</param>
        /// <param name="secondNumber">Second number</param>
        /// <returns></returns>
        private static int QuickSolutionForStein(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0)
            {
                return Math.Abs(secondNumber);
            }
            if (secondNumber == 0)
            {
                return Math.Abs(firstNumber);
            }
            return SteinMethodEvaluation(firstNumber, secondNumber);
        }
        /// <summary>
        /// Validation method for array of parameters
        /// </summary>
        /// <exception cref="ArgumentNullException">Throws, when ref of array is null</exception>
        /// <param name="numbers">Array of parameters</param>
        private static void Valid(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException($"The value of {nameof(numbers)} can not be not null");
            }
        }
    }
}
