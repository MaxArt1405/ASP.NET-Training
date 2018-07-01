using System.Diagnostics;

namespace FindNextBiggerNumberMethod
{
    class GetTimeOfFindingNextBiggerNumber
    {
        public static Stopwatch GetLeadTimeFindNextBiggerNumber(int number)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            FindNextBiggerNumber.FindingNextBiggerNumber(number);
            timer.Stop();
            return timer;
        }
    }
}
