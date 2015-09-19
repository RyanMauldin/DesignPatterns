using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    public class PersonEnumerableAdapter : Adapter<IEnumerable<ICustomer>, IEnumerable<IPerson>>
    {
        public override IEnumerable<IPerson> Adapt(IEnumerable<ICustomer> value)
        {
            if (value == null)
                return null;

            return value.Select(
                p => new Person
                {
                    Id = p.Id,
                    FirstName = p.FirstName,
                    MiddleName = p.MiddleName,
                    LastName = p.LastName,
                    CreatedOn = p.CreatedOn,
                    Email = p.Email,
                    LastModifiedOn = p.LastModifiedOn
                });
        }
    }
}
