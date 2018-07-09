using System;
using NUnit.Framework;
using StringExtentionLibrary;

namespace StringExtensionLibraryTests
{
    [TestFixture]
    public class StringExtentionTests
    {
        [TestCase("0110111101100001100001010111111", 2, ExpectedResult = 934331071)]
        [TestCase("01101111011001100001010111111", 2, ExpectedResult = 233620159)]
        [TestCase("11101101111011001100001010", 2, ExpectedResult = 62370570)]
        [TestCase("1AeF101", 16, ExpectedResult = 28242177)]
        [TestCase("1ACB67", 16, ExpectedResult = 1756007)]
        [TestCase("764241", 8, ExpectedResult = 256161)]
        [TestCase("10", 5, ExpectedResult = 5)]
        [TestCase("25", 10, ExpectedResult = 25)]
        public long ToDecimalConverterTest_Success(string source, int basis)
        {
            return source.ToDecimalConverter(new Notation(basis));
        }

        [TestCase("SA123", 2)]
        [TestCase("987", 8)]
        [TestCase("97rt", 16)]
        [TestCase("1AeF101", 2)]
        public void ToDecimalConverterTest_WithInvalidSymbols_ThrowArgumentException(string source, int basis)
        {
            Assert.Throws<ArgumentException>(() => source.ToDecimalConverter(new Notation(basis)));
        }

        [TestCase(null, 8)]
        [TestCase("", 16)]
        public void ToDecimalConverterTest_WithNullOrEmptyString_ThrowArgumentException(string source, int basis)
        {
            Assert.Throws<ArgumentNullException>(() => source.ToDecimalConverter(new Notation(basis)));
        }

        [TestCase("11111111111111111111111111111111", 2)]
        [TestCase("156516551", 20)]
        public void ToDecimalConverterTest_OverflowValue(string source, int basis)
        { 
            Assert.Throws<OverflowException>(() => source.ToDecimalConverter(new Notation(basis)));
        }
    }
}
