using System;
using MethodsForFindingGCD;
using NUnit.Framework;

namespace MethodForFindingGCDTests
{
    [TestFixture]
    public class TestForEuclideanMethod
    {
        [TestCase(1, 10, ExpectedResult = 1)]
        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(24, 24, ExpectedResult = 24)]
        [TestCase(-5, 10, ExpectedResult = 5)]
        [TestCase(5, 0, ExpectedResult = 5)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(0, -5, ExpectedResult = 5)]
        public int TestingEuclideanMethodForTwoParams(int a, int b)
        {
            return EuclideanAndSteinMethodForFindingGCD.EuclideanMethod(a, b);
        }

        [TestCase(-13, 25, ExpectedResult = 1)]
        [TestCase(4, 16, 8, ExpectedResult = 4)]
        [TestCase(5, 40, 20, 10, ExpectedResult = 5)]
        [TestCase(24, 50, 72, 84, 92, ExpectedResult = 2)]
        [TestCase(-12, 24, -48, 96, -192, 384, ExpectedResult = 12)]
        [TestCase(13, 14, 25, 26, 32, 44, 46, 52, ExpectedResult = 1)]
        public int TestingEuclideanMethodForThreeAndMoreParams(int a, int b, params int[] numbers)
        {
            return EuclideanAndSteinMethodForFindingGCD.EuclideanMethod(a, b, numbers);
        }

        [Test]
        public void Euclidean_NullArgument_ArgumentsNullException()
        {
            Assert.Throws<ArgumentNullException>(() => EuclideanAndSteinMethodForFindingGCD.EuclideanMethod(4, 16, null));
        }
    }
    [TestFixture]
    public class TestForSteinMethod
    {
        [TestCase(1, 10, ExpectedResult = 1)]
        [TestCase(5, 10, ExpectedResult = 5)]
        [TestCase(24, 24, ExpectedResult = 24)]
        [TestCase(-5, 10, ExpectedResult = 5)]
        [TestCase(5, 0, ExpectedResult = 5)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(0, -5, ExpectedResult = 5)]
        public int TestingEuclideanMethodForTwoParams(int a, int b)
        {
            return EuclideanAndSteinMethodForFindingGCD.SteinMethod(a, b);
        }

        [TestCase(-13, 25, ExpectedResult = 1)]
        [TestCase(4, 16, 8, ExpectedResult = 4)]
        [TestCase(5, 40, 20, 10, ExpectedResult = 5)]
        [TestCase(24, 50, 72, 84, 92, ExpectedResult = 2)]
        [TestCase(-12, 24, -48, 96, -192, 384, ExpectedResult = 12)]
        [TestCase(13, 14, 25, 26, 32, 44, 46, 52, ExpectedResult = 1)]
        public int TestingEuclideanMethodForThreeAndMoreParams(int a, int b, params int[] numbers)
        {
            return EuclideanAndSteinMethodForFindingGCD.SteinMethod(a, b, numbers);
        }
        [Test]
        public void Euclidean_NullArgument_ArgumentsNullException()
        {
            Assert.Throws<ArgumentNullException>(() => EuclideanAndSteinMethodForFindingGCD.SteinMethod(4, 16, null));
        }
    }
}
