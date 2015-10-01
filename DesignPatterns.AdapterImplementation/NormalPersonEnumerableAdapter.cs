using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    /// <summary>
    /// Adapts an IEnumerable ICustomer interface into an
    /// IEnumerable IPerson interface by creating
    /// new NormalPerson objects.
    /// </summary>
    public class NormalPersonEnumerableAdapter :
        Adapter<IEnumerable<ICustomer>, IEnumerable<IPerson>>
    {
        /// <summary>
        /// Adapts an IEnumerable ICustomer interface into an
        /// IEnumerable IPerson interface by creating
        /// new NormalPerson objects via NormalPersonAdapter.
        /// </summary>
        /// <param name="value">The input IEnumerable ICustomer objects to adapt.</param>
        /// <returns>IEnumerable IPerson interfaces created as NormalPerson, or null if passed a null object.</returns>
        public override IEnumerable<IPerson> Adapt(IEnumerable<ICustomer> value)
        {
            if (value == null)
                return null;

            var normalPersonAdpater = new NormalPersonAdapter();

            return value.Select(
                p => normalPersonAdpater.Adapt(p));
        }
    }
}
