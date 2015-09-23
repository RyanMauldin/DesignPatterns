using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    public class CustomerEnumerableAdapter :
        Adapter<IEnumerable<IPerson>, IEnumerable<ICustomer>>
    {
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
