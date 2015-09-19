using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    public class PersonAdapter : Adapter<ICustomer, IPerson>
    {
        public override IPerson Adapt(ICustomer customer)
        {
            if (customer == null)
                return null;

            return new Person
            {
                Id = customer.Id,
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
