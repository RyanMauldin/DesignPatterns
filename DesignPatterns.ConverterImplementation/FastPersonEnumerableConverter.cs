using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.ConverterImplementation
{
    /// <summary>
    /// Converts an IEnumerable ICustomer interface into an
    /// IEnumerable IPerson interface by creating
    /// new FastPerson objects.
    /// </summary>
    public class FastPersonEnumerableConverter :
        Converter<IEnumerable<ICustomer>, IEnumerable<IPerson>>
    {
        /// <summary>
        /// Converts an IEnumerable ICustomer interface into an
        /// IEnumerable IPerson interface by creating
        /// new FastPerson objects via FastPersonConverter.
        /// </summary>
        /// <param name="value">The input IEnumerable ICustomer objects to convert.</param>
        /// <returns>IEnumerable IPerson interfaces created as FastPerson, or null if passed a null object.</returns>
        public override IEnumerable<IPerson> Convert(IEnumerable<ICustomer> value)
        {
            if (value == null)
                return null;

            var fastPersonAdpater = new FastPersonConverter();

            return value.Select(
                p => fastPersonAdpater.Convert(p));
        }
    }
}
