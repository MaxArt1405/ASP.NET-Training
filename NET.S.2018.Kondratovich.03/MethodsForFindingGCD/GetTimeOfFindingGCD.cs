using System.Diagnostics;

namespace MethodForFindingGCDTests
{
    class GetTimeOfFindingGCD
    {
        /// <summary>
        /// Method of computing evaluation time Euclidean method
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns></returns>
        public static Stopwatch GetLeadTimeFindingGCDByEuclid(int a, int b)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            MethodsForFindingGCD.EuclideanAndSteinMethodForFindingGCD.EuclideanMethod(a, b);
            timer.Stop();
            return timer;
        }
        /// <summary>
        /// Method of computing evaluation Stein method time
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns></returns>
        public static Stopwatch GetLeadTimeFindingGCDByStein(int a, int b)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            MethodsForFindingGCD.EuclideanAndSteinMethodForFindingGCD.SteinMethod(a, b);
            timer.Stop();
            return timer;
        }
    }
}
