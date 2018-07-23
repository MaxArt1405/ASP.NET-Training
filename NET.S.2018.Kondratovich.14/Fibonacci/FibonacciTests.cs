using System;
using System.Linq;
using Fibonacci;
using NUnit.Framework;

namespace FibnacciTest
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        [TestCase(0, new int[] { })]
        [TestCase(6, new int[] { 0, 1, 1, 2, 3, 5 })]
        [TestCase(12, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 })]
        [TestCase(18, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597 })]
        [TestCase(24 ,new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657 })]
        public void FibonacciTestSuccess(int count, int[] expected)
        {
           // Assert.AreEqual(FibonacciGenerator.GenerateFibonacci(count), expected);
             Assert.AreEqual(FibonacciGenerator.GenerateFibonacci().Take(count), expected);
        }
    }
}
