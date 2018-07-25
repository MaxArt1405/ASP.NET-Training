using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class GenericQueue<T> : IEnumerable<T>
    {
        private T[] _container = { };
        private int _head = 0;
        private int _tail = -1;
        private int _count = 0;
        private readonly int _capacity = 1;
        private const int DefaultCapacity = 1;

        public GenericQueue() : this(DefaultCapacity) { }
        public GenericQueue(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(capacity)} must be greater than 0");
            }
            _capacity = capacity;
            _container = new T[capacity];
        }
        public GenericQueue(IEnumerable<T> entities)
        {
            if (entities is null)
            {
                throw new ArgumentNullException(nameof(entities));
            }

            _container = entities.ToArray();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            T[] copiedContainer = new T[_container.Length];
            Array.Copy(_container, copiedContainer, copiedContainer.Length);
            return new EnumeratorForQueue<T>(copiedContainer, _tail, _head, _count);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            T[] copyContainer = new T[_container.Length];
            Array.Copy(_container, copyContainer, copyContainer.Length);
            return new EnumeratorForQueue<T>(copyContainer, _tail, _head, _count);
        }

        public void Enqueue(T obj)
        {
            if (_count + 1 <= _container.Length)
            {
                if (_tail + 1 > _container.Length - 1)
                {
                    _tail = -1;
                }
            }
            else
            {
                ExtendsQueue();
            }
            _tail++;
            _count++;
            _container[_tail] = obj;
        }
        public T Dequeue()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            if (_head > _container.Length - 1)
            {
                _head = 0;
            }

            T result = _container[_head];
            _container[_head] = default(T);
            _head++;
            _count--;

            return result;
        }
        public void Clear()
        {
            _container = new T[_capacity];
            _tail = -1;
            _head = 0;
            _count = 0;
        }
        public T Peek()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            return _container[_head];
        }

        private void ExtendsQueue()
        {
            if (_tail < _head)
            {
                ExtendsContainer(ref _container, _capacity);
                _head = 0;
                _tail = _count - 1;
            }
            else
            {
                Array.Resize(ref _container, _container.Length + _capacity);
            }
        }
        private void ExtendsContainer(ref T[] array, int capacity)
        {
            T[] newArray = new T[array.Length + capacity];
            int indexOldArray = 0;
            int indexNewArray = 0;

            while (indexOldArray < array.Length)
            {
                if (indexOldArray - 1 == _tail)
                {
                    indexNewArray = indexNewArray + capacity;
                }

                newArray[indexNewArray] = array[indexOldArray];
                indexOldArray++;
                indexNewArray++;
            }
            array = newArray;
        }
    }
}
