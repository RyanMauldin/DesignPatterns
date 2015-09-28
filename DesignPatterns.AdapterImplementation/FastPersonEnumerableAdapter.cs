using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    public class FastPersonEnumerableAdapter :
        Adapter<IEnumerable<ICustomer>, IEnumerable<IPerson>>
    {
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
