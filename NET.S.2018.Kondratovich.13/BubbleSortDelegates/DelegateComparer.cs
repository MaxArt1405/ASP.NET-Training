using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortDelegates
{
    public class DelegateComparer : IComparer<int>
    {
        private readonly Comparison<int> _delegate;

        public DelegateComparer(Comparison<int> delegateToCompare)
        {
            _delegate = delegateToCompare ?? throw new ArgumentNullException(nameof(delegateToCompare));
        }
        public int Compare(int x, int y) => _delegate(x, y);
    }
}
