using NUnit.Framework;

namespace Customer.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        private readonly NET.S._2018.Kondratovich._07.Customer customer = 
            new NET.S._2018.Kondratovich._07.Customer("Jeffrey Richter", "+1 (425) 555-0100", 1000000);
        [TestCase("Full", ExpectedResult = "Customer record: Jeffrey Richter, +1 (425) 555-0100, 1000000")]
        [TestCase("Name", ExpectedResult = "Customer record: Jeffrey Richter")]
        [TestCase("Contact", ExpectedResult = "Customer record: +1 (425) 555-0100")]
        [TestCase("Revenue", ExpectedResult = "Customer record: 1000000")]
        [TestCase("NameRevenue", ExpectedResult = "Customer record: Jeffrey Richter, 1000000")]
        [TestCase("ContactRevenue", ExpectedResult = "Customer record: +1 (425) 555-0100, 1000000")]
        [TestCase("NameContact", ExpectedResult = "Customer record: Jeffrey Richter, +1 (425) 555-0100")]
        public string CustomerReprezentations_SuccesfullTest(string format)
        {
            return customer.ToString(format);
        }
    }
}
