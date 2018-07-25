using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public struct EnumeratorForQueue<T> : IEnumerator<T>
    {
        private readonly T[] _aggregate;
        private readonly int _queueTail;
        private readonly int _queueHead;
        private readonly int _queueCount;
        private int _currentIndex;
        private int _currentCount;

        public EnumeratorForQueue(T[] aggregate, int tail, int head, int count)
        {
            if (aggregate is null)
            {
                throw new ArgumentNullException(nameof(aggregate));
            }

            _aggregate = aggregate;
            _queueTail = tail;
            _queueHead = head;
            _queueCount = count;
            _currentIndex = head - 1;
            _currentCount = 0;
        }

        public T Current
        {
            get
            {
                if (_currentIndex == -1 || _currentIndex == _queueCount)
                {
                    throw new InvalidOperationException();
                }

                return _aggregate[_currentIndex];
            }
        }

        object IEnumerator.Current => _aggregate[_currentIndex];

        public void Dispose() { }

        public bool MoveNext()
        {
            if (_currentCount >= _queueCount)
            {
                return false;
            }

            if (_currentIndex == _aggregate.Length - 1)
            {
                _currentIndex = -1;
            }
            _currentIndex++;
            _currentCount++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = _queueTail;
            _currentCount = 0;
        }
    }
}
