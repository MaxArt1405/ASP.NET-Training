using NET.S._2018.Kondratovich._07;
using NUnit.Framework;
using System;

namespace Customer.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        private readonly NET.S._2018.Kondratovich._07.Customer customer = 
            new NET.S._2018.Kondratovich._07.Customer("Jeffrey Richter", "+375 (29) 268-0859", 2145854);

        [TestCase("Full", ExpectedResult = "Customer record: Jeffrey Richter, +375 (29) 268-0859, 2,145,854.00")]
        [TestCase("Name", ExpectedResult = "Customer record: Jeffrey Richter")]
        [TestCase("Contact", ExpectedResult = "Customer record: +375 (29) 268-0859")]
        [TestCase("Revenue", ExpectedResult = "Customer record: 2,145,854.00")]
        [TestCase("NameRevenue", ExpectedResult = "Customer record: Jeffrey Richter, 2,145,854.00")]
        [TestCase("ContactRevenue", ExpectedResult = "Customer record: +375 (29) 268-0859, 2,145,854.00")]
        [TestCase("NameContact", ExpectedResult = "Customer record: Jeffrey Richter, +375 (29) 268-0859")]
        public string CustomerReprezentations_SuccesfullTest(string format)
        {
            return customer.ToString(format);
        }

        [TestCase("Full+", null, ExpectedResult = "Customer record: Name: Jeffrey Richter, Revenue: 2,145,854.00, Phone: +375 (29) 268-0859")]
        [TestCase("Name+", null, ExpectedResult = "Customer record name: Jeffrey Richter")]
        [TestCase("Contact+", null, ExpectedResult = "Customer record contact phone: +375 (29) 268-0859")]
        [TestCase("Revenue+", null, ExpectedResult = "Customer record revenue: 2,145,854.00")]
        [TestCase("ByWord+", null, ExpectedResult = "Customer record: Revenue - two one four five eight five four")]
        public string Custom_CustomerReprezentations_SuccesfullTest(string format, IFormatProvider formatProvider)
        {
            CustomersFormatter custom = new CustomersFormatter();
            return custom.Format(format, customer, formatProvider);
        }
    }
}
