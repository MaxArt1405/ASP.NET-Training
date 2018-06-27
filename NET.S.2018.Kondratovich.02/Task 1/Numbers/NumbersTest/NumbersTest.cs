using System;
using Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumbersTest
{
    [TestClass]
    public class NumbersTest
    {

        [TestMethod]
        public void FirstTest_Inclusion_Numbers_Success()
        {
            int first = 15;
            int second = 15;
            int startPosition = 0;
            int finishPosition = 0;

            int actual = Numbers.Numbers.Insertion(first, second, startPosition, finishPosition);

            Assert.AreEqual(actual, 15);
        }

        [TestMethod]
        public void SecondTest_Inclusion_Numbers_Success()
        {
            int first = 8;
            int second = 15;
            int startPosition = 0;
            int finishPosition = 0;

            int actual = Numbers.Numbers.Insertion(first, second, startPosition, finishPosition);

            Assert.AreEqual(actual, 9); //15
        }

        [TestMethod]
        public void ThirdTest_Inclusion_Numbers_Success()
        {
            int first = 8;
            int second = 15;
            int startPosition = 3;
            int finishPosition = 8;

            int actual = Numbers.Numbers.Insertion(first, second, startPosition, finishPosition);

            Assert.AreEqual(actual, 120); //15
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Inclusion_Numbers_ArgumentException()
        {
            int first = 0;
            int second = 15;
            int startPosition = 30;
            int finishPosition = 3;

            int actual = Numbers.Numbers.Insertion(first, second, startPosition, finishPosition);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Inclusion_Numbers_ArgumentOutOfRangeException_Of_StartPosition()
        {
            int first = 0;
            int second = 15;
            int startPosition = -1;
            int finishPosition = 30;

            int actual = Numbers.Numbers.Insertion(first, second, startPosition, finishPosition);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Inclusion_Numbers_ArgumentOutOfRangeException_Of_FinishPosition()
        {
            int first = 0;
            int second = 15;
            int startPosition = 1;
            int finishPosition = 35;

            int actual = Numbers.Numbers.Insertion(first, second, startPosition, finishPosition);
        }

    }
}
