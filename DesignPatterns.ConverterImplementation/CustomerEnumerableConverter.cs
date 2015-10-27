using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.ConverterImplementation
{
    /// <summary>
    /// Converts an IEnumerable IPerson interface into an
    /// IEnumerable ICustomer interface by creating
    /// new Customer objects.
    /// </summary>
    public class CustomerEnumerableConverter :
        Converter<IEnumerable<IPerson>, IEnumerable<ICustomer>>
    {
        /// <summary>
        /// Converts an IEnumerable IPerson interface into an
        /// IEnumerable ICustomer interface by creating
        /// new Customer objects via CustomerConverter.
        /// </summary>
        /// <param name="value">The input IEnumerable IPerson objects to convert.</param>
        /// <returns>IEnumerable ICustomer interfaces created as Customer, or null if passed a null object.</returns>
        public override IEnumerable<ICustomer> Convert(IEnumerable<IPerson> value)
        {
            if (value == null)
                return null;

            var adpater = new CustomerConverter();

            return value.Select(
                p => adpater.Convert(p));
        }
    }
}
