using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    public class NormalPersonEnumerableAdapter :
        Adapter<IEnumerable<ICustomer>, IEnumerable<IPerson>>
    {
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
