using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    /// <summary>
    /// Adapts an IEnumerable IPerson interface into an
    /// IEnumerable ICustomer interface by creating
    /// new Customer objects.
    /// </summary>
    public class CustomerEnumerableAdapter :
        Adapter<IEnumerable<IPerson>, IEnumerable<ICustomer>>
    {
        /// <summary>
        /// Adapts an IEnumerable IPerson interface into an
        /// IEnumerable ICustomer interface by creating
        /// new Customer objects via CustomerAdapter.
        /// </summary>
        /// <param name="value">The input IEnumerable IPerson objects to adapt.</param>
        /// <returns>IEnumerable ICustomer interfaces created as Customer, or null if passed a null object.</returns>
        public override IEnumerable<ICustomer> Adapt(IEnumerable<IPerson> value)
        {
            if (value == null)
                return null;

            var adpater = new CustomerAdapter();

            return value.Select(
                p => adpater.Adapt(p));
        }
    }
}
