using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    /// <summary>
    /// Adapts an IEnumerable ICustomer interface into an
    /// IEnumerable IPerson interface by creating
    /// new FastPerson objects.
    /// </summary>
    public class FastPersonEnumerableAdapter :
        Adapter<IEnumerable<ICustomer>, IEnumerable<IPerson>>
    {
        /// <summary>
        /// Adapts an IEnumerable ICustomer interface into an
        /// IEnumerable IPerson interface by creating
        /// new FastPerson objects via FastPersonAdapter.
        /// </summary>
        /// <param name="value">The input IEnumerable ICustomer objects to adapt.</param>
        /// <returns>IEnumerable IPerson interfaces created as FastPerson, or null if passed a null object.</returns>
        public override IEnumerable<IPerson> Adapt(IEnumerable<ICustomer> value)
        {
            if (value == null)
                return null;

            var fastPersonAdpater = new FastPersonAdapter();

            return value.Select(
                p => fastPersonAdpater.Adapt(p));
        }
    }
}
