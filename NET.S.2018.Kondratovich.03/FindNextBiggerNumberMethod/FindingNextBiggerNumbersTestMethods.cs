using System;
using NUnit.Framework;
using FindNextBiggerNumberMethod;

namespace FindNextBiggerNumberMethod.Tests
{
    [TestFixture]
    public class FindNextBiggerNumberTest
    {
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(414, 441)]
        [TestCase(144, 414)]
        [TestCase(1234321, 1241233)]
        [TestCase(1234126, 1234162)]
        [TestCase(3456432, 3462345)]
        [TestCase(10, -1)]
        [TestCase(20, -1)]
        public void FindNextBiggerNumber_Test_CorrectValues_Success(int number, int expected)
        {
            int result = FindNextBiggerNumber.FindingNextBiggerNumber(number);

            Assert.AreEqual(result, expected);
        }

        [TestCase(-10)]
        [TestCase(-5)]
        public void FindNextBiggerNumber_WrongValues_ReturnException(int number)
        {
            Assert.Throws<ArgumentException>(
                () => FindNextBiggerNumber.FindingNextBiggerNumber(number));
        }
    }
}
