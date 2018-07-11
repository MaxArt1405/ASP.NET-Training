using System;
using System.Globalization;

namespace NET.S._2018.Kondratovich._07
{
    public class Customer : IFormattable
    {
        public string Name { get; set; }

        public string ContactPhone { get; set; }

        public decimal Revenue { get; set; }

        public Customer(string name, string contactPhone, decimal revenue)
        {
            Name = name;
            ContactPhone = contactPhone;
            Revenue = revenue;
        }

        public override string ToString()
        {
            return string.Format("Customer record: {0}, {1}, {2}", Name, ContactPhone, Revenue);
        }

        public string ToString(string format, IFormatProvider formatProvider = null)
        {
            if (String.IsNullOrEmpty(format))
            {
                format = "FULL";
            }

            if (formatProvider == null)
            {
                formatProvider = CultureInfo.CurrentCulture;
            }

            switch (format.ToUpper())
            {
                case "FULL":
                    return ToString();
                case "NAME":
                    return string.Format(formatProvider, "Customer record: {0}", Name);
                case "CONTACT":
                    return string.Format(formatProvider, "Customer record: {0}", ContactPhone);
                case "REVENUE":
                    return string.Format(formatProvider, "Customer record: {0}", Revenue);
                default:
                    throw new FormatException(string.Format("The {0} format string is not supported.", format));
            }
        }
    }
}
