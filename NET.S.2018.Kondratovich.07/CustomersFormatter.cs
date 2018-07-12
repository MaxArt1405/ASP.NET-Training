using System;
using System.Globalization;
using System.Text;

namespace NET.S._2018.Kondratovich._07
{
    public class CustomersFormatter : ICustomFormatter, IFormatProvider
    {
        private readonly string[] StringNumbers = "zero one two three four five six seven eight nine minus point".Split();
        private readonly IFormatProvider parentFormatProvider;
        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public CustomersFormatter() : this(CultureInfo.CurrentCulture) { }
        /// <summary>
        /// Ctor with one parameter.
        /// </summary>
        /// <param name="parent">Format provider.</param>
        public CustomersFormatter(IFormatProvider parent)
        {
            parentFormatProvider = parent;
        }
        /// <summary>
        /// Converts Customer object into string representation using additional formats.
        /// </summary>
        /// <param name="format">Format of string representation.</param>
        /// <param name="obj">Customer object for converting.</param>
        /// <param name="formatProvider">Format provider.</param>
        /// <returns>String representation of the customer.</returns>
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            Customer customer = arg as Customer;
            if (customer is null)
            {
                throw new ArgumentNullException($"The {nameof(customer)} is null.");
            }

            if (string.IsNullOrEmpty(format))
            {
                format = "FULL+";
            }

            if (formatProvider is null)
            {
                formatProvider = parentFormatProvider;
            }

            switch (format.ToUpper())
            {
                case "FULL+":
                    return $"Customer record: Name: {customer.Name}, Revenue: {customer.Revenue.ToString("N", NumberFormatInfo.InvariantInfo)}, Phone: {customer.ContactPhone}";
                case "BYWORD+":
                    return $"Customer record: Revenue - {NumberIntoWords((double)customer.Revenue)}";
                case "NAME+":
                    return $"Customer record name: {customer.Name}";
                case "CONTACT+":
                    return $"Customer record contact phone: {customer.ContactPhone}";
                case "REVENUE+":
                    return $"Customer record revenue: {customer.Revenue.ToString("N", NumberFormatInfo.InvariantInfo)}";
                default:
                    throw new FormatException($"This format {format} is not supported.");
            }
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }
            return null;
        }
        private string NumberIntoWords(double number)
        {
            StringBuilder result = new StringBuilder();
            string digitList = number.ToString();
            foreach (char digit in digitList)
            {
                int i = "0123456789+-.".IndexOf(digit);
                if (i == -1) continue;
                if (result.Length > 0) result.Append(' ');
                result.Append(StringNumbers[i]);
            }
            return result.ToString();
        }
    }
}
