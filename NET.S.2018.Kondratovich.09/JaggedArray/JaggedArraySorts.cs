using System.Linq;

namespace JaggedArray
{
        public class IncreasingSum : IComparer<int>
        {
            public int Compare(int[] firstItem, int[] secondItem)
            {
                if (firstItem == null && secondItem == null)
                {
                    return 0;
                }
                if (firstItem == null)
                {
                    return 1;
                }
                if (secondItem == null)
                {
                    return -1;
                }

                return firstItem.Sum() - secondItem.Sum();
            }
        }
        public class DecreasingSum : IComparer<int>
        {
            public int Compare(int[] firstItem, int[] secondItem)
            {
                if (firstItem == null && secondItem == null)
                {
                    return 0;
                }
                if (firstItem == null)
                {
                    return -1;
                }
                if (firstItem == null)
                {
                    return 1;
                }

                return secondItem.Sum() - firstItem.Sum();
            }
        }
        public class IncreasingMaxElements : IComparer<int>
        {
            public int Compare(int[] firstItem, int[] secondItem)
            {
                if (firstItem == null && secondItem == null)
                {
                    return 0;
                }
                if (firstItem == null)
                {
                    return 1;
                }
                if (secondItem == null)
                {
                    return -1;
                }

                return firstItem.Max() - secondItem.Max();
            }
        }
        public class DecreasingMaxElements : IComparer<int>
        {
            public int Compare(int[] firstItem, int[] secondItem)
            {
                if (firstItem == null && secondItem == null)
                {
                    return 0;
                }
                if (firstItem == null)
                {
                    return 1;
                }
                if (secondItem == null)
                {
                    return -1;
                }

                return secondItem.Max() - firstItem.Max();
            }
        }
        public class IncreasingMinElements : IComparer<int>
        {
            public int Compare(int[] firstItem, int[] secondItem)
            {
                if (firstItem == null && secondItem == null)
                {
                    return 0;
                }
                if (firstItem == null)
                {
                    return 1;
                }
                if (secondItem == null)
                {
                    return -1;
                }

                return firstItem.Min() - secondItem.Min();
            }
        }
        public class DecreasingMinElements : IComparer<int>
        {
            public int Compare(int[] firstItem, int[] secondItem)
            {
                if (firstItem == null && secondItem == null)
                {
                    return 0;
                }
                if (firstItem == null)
                {
                    return 1;
                }
                if (firstItem == null)
                {
                    return -1;
                }

                return secondItem.Min() - firstItem.Min();
            }
        }
}
