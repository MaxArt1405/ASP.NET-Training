using System;
using System.Globalization;

namespace NET.S._2018.Kondratovich._07
{
    public class Customer : IFormattable
    {
        /// <summary>
        /// String property Name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// String property Contact Phone.
        /// </summary>
        public string ContactPhone { get; set; }
        /// <summary>
        /// Decimal property Revenue.
        /// </summary>
        public decimal Revenue { get; set; }
        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="name">Name of the customer.</param>
        /// <param name="phone">Contact phone of the customer.</param>
        /// <param name="revenue">Revenue of the customer.</param>
        public Customer(string name, string contactPhone, decimal revenue)
        {
            Name = name;
            ContactPhone = contactPhone;
            Revenue = revenue;
        }
        /// <summary>
        /// Overriding method converts Customer object into string representation with general format.
        /// </summary>
        /// <returns>String representation of the customer.</returns>
        public override string ToString()
        {
            return string.Format("Customer record: {0}, {1}, {2}", Name, ContactPhone, Revenue.ToString("N", NumberFormatInfo.InvariantInfo));
        }
        /// <summary>
        /// Converts Customer object into string representation.
        /// </summary>
        /// <param name="format">Format of string representation.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <returns>String representation of the customer.</returns>
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
                    return string.Format(formatProvider, "Customer record: {0}", Revenue.ToString("N", NumberFormatInfo.InvariantInfo));
                case "NAMEREVENUE":
                    return string.Format(formatProvider, "Customer record: {0}, {1}", Name, Revenue.ToString("N", NumberFormatInfo.InvariantInfo));
                case "CONTACTREVENUE":
                    return string.Format(formatProvider, "Customer record: {0}, {1}", ContactPhone, Revenue.ToString("N", NumberFormatInfo.InvariantInfo));
                case "NAMECONTACT":
                    return string.Format(formatProvider, "Customer record: {0}, {1}", Name, ContactPhone);
                default:
                    throw new FormatException(string.Format("The {0} format string is not supported.", format));
            }
        }
    }
}
