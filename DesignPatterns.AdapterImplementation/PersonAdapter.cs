using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    public class PersonAdapter : Adapter<ICustomer, IPerson>
    {
        public override IPerson Adapt(ICustomer customer)
        {
            return new Person
            {
                FirstName = customer.FirstName,
                MiddleName = customer.MiddleName,
                LastName = customer.LastName,
                CreatedOn = customer.CreatedOn,
                Email = customer.Email,
                LastModifiedOn = customer.LastModifiedOn
            };
        }
    }
}
