using System;
using System.Linq;
using NUnit.Framework;
using Queue;

namespace QueueTest
{
    [TestFixture]
    class QueueViaWiseArrayTests
    {
        [Test]
        public void GenericQueue_Enqueue_Success()
        {
            GenericQueue<int> queue = new GenericQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(5);
            int[] expected = { 10, 5 };
            CollectionAssert.AreEqual(queue, expected);
        }
        [Test]
        public void GenericQueue_Dequeue_Success()
        {
            GenericQueue<int> queue = new GenericQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(5);
            int dequeuedItem = queue.Dequeue();
            int expected = 10;

            Assert.AreEqual(expected, dequeuedItem);
        }
        [Test]
        public void GenericQueue_Clear()
        {
            GenericQueue<int> queue = new GenericQueue<int>();
            GenericQueue<int> empty = new GenericQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(5);
            queue.Clear();

            CollectionAssert.AreEqual(queue, empty);
        }
        [Test]
        public void GenericQueue_Peek()
        {
            GenericQueue<int> queue = new GenericQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(5);
            int oldCount = queue.Count();
            int result = queue.Peek();
            int expected = 10;
            int newCount = queue.Count();

            Assert.AreEqual(expected, result);
            Assert.AreEqual(oldCount, newCount);
        }
        [Test]
        public void GenericQueue_IEnumerable()
        {
            GenericQueue<int> queue = new GenericQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int[] expected = { 1, 2, 3 };

            Assert.AreEqual(expected,queue);
        }
        [Test]
        public void GenericQueue_Empty_InvalidOperationException()
        {
            GenericQueue<int> queue = new GenericQueue<int>();
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }
        [Test]
        public void GenericQueue_Capacity_LessThan1_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new GenericQueue<string>(-1));
        }
    }
}
