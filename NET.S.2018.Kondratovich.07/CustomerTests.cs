using NET.S._2018.Kondratovich._07;
using NUnit.Framework;
using System;

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

        [TestCase("Full+", null, ExpectedResult = "Customer record: Name: Jeffrey Richter, Revenue: 1000000, Phone: +1 (425) 555-0100")]
        [TestCase("Name+", null, ExpectedResult = "Customers name: Jeffrey Richter")]
        [TestCase("Contact+", null, ExpectedResult = "Customers record contact phone: +1 (425) 555-0100")]
        [TestCase("Revenue+", null, ExpectedResult = "Customers revenue: 1000000")]
         public string Custom_CustomerReprezentations_SuccesfullTest(string format, IFormatProvider formatProvider)
        {
            CustomersFormatter custom = new CustomersFormatter();
            return custom.Format(format, customer, formatProvider);
        }
    }
}
