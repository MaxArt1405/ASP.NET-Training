using System;
using System.Globalization;

namespace NET.S._2018.Kondratovich._07
{
    public class CustomersFormatter : ICustomFormatter, IFormatProvider
    {
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
                    return $"Customer record: Name: {customer.Name}, Revenue: {customer.Revenue}, Phone: {customer.ContactPhone}";
                case "NAME+":
                    return $"Customer record name: {customer.Name}";
                case "CONTACT+":
                    return $"Customer record contact phone: {customer.ContactPhone}";
                case "REVENUE+":
                    return $"Customer record revenue: {customer.Revenue}";
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
    }
}
