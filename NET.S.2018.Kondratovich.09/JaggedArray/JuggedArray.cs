using System;

namespace JaggedArray
{
    public static class JuggedArray
    {
        public static void BubbleSort<T>(this T[][] jaggedArray, IComparer<T> comparer)
        {
            Valid(jaggedArray, comparer);
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i < jaggedArray.Length - 1; i++)
                {
                    if (comparer.Compare(jaggedArray[i], jaggedArray[i + 1]) > 0)
                    {
                        Swap(ref jaggedArray[i], ref jaggedArray[i + 1]);
                        flag = true;
                    }
                }
            }   
        }
        private static void Valid<T>(T[][] jaggedArray, IComparer<T> comparer)
        {
            if (jaggedArray == null)
                throw new ArgumentNullException(nameof(jaggedArray));
            if (comparer == null)
                throw new ArgumentNullException(nameof(comparer));
        }
        private static void Swap<T>(ref T [] a, ref T [] b)
        {
            T[] tmp = a;
            a = b;
            b = tmp;
        }
    }
}
