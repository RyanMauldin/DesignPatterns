using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    public class PersonEnumerableAdapter :
        Adapter<IEnumerable<ICustomer>, IEnumerable<IPerson>>
    {
        public override IEnumerable<IPerson> Adapt(IEnumerable<ICustomer> value)
        {
            if (value == null)
                return null;

            var personAdpater = new PersonAdapter();

            return value.Select(
                p => personAdpater.Adapt(p));
        }
    }
}
