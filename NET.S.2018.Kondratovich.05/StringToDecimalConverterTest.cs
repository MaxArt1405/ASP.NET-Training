using System;
using NUnit.Framework;

namespace DecimalConverter.Test
{
    [TestFixture]
    public class StringToDecimalConverterTest
    {
        [TestCase("0110111101100001100001010111111", 2, ExpectedResult = 934331071)]
        [TestCase("01101111011001100001010111111", 2, ExpectedResult = 233620159)]
        [TestCase("11101101111011001100001010", 2, ExpectedResult = 62370570)]
        [TestCase("1AeF101", 16, ExpectedResult = 28242177)]
        [TestCase("1ACB67", 16, ExpectedResult = 1756007)]
        [TestCase("764241", 8, ExpectedResult = 256161)]
        [TestCase("10", 5, ExpectedResult = 5)]
        public int ConvertingStringToDecimalTest(string number, int scale)
        {
            Notation notation = new Notation(scale);
            return StringToDecimalConverter.ConvertingToDecimal(number, notation);
        }

        [TestCase("764241", 20)]
        public void StringToDecimalConverterTest_ThrowsArgumentException(string number, int scale)
        {
            Notation notation = new Notation(scale);
            Assert.Throws<ArgumentException>(() => StringToDecimalConverter.ConvertingToDecimal(number, notation));
        }

        [TestCase(null, 2)]
        [TestCase("", 10)]
        public void StringToDecimalConverterTest_ThrowsNullException(string number, int scale)
        {
            Notation notation = new Notation(scale);
            Assert.Throws<ArgumentNullException>(() => StringToDecimalConverter.ConvertingToDecimal(number, notation));
        }

        [TestCase("100000000000000111000000000000011100000", 2)]
        [TestCase("10101010111101010101010101010101010101011", 2)]
        public void StringToDecimalConverterTest_ThrowsOverflowException(string number, int scale)
        {
            Notation notation = new Notation(scale);
            Assert.Throws<OverflowException>(() => StringToDecimalConverter.ConvertingToDecimal(number, notation));
        }
    }
}
