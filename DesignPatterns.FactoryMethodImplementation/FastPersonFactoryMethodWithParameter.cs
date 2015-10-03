using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.FactoryMethodImplementation
{
    public class FastPersonFactoryMethodWithParameter :
        FactoryMethodWithParameter<ICustomer, FastPerson>
    {
        public override FastPerson Create(ICustomer value)
        {
            if (value == null)
                return null;

            return new FastPerson
            {
                Id = value.Id,
                FirstName = value.FirstName,
                MiddleName = value.MiddleName,
                LastName = value.LastName,
                Email = value.Email,
                CreatedOn = value.CreatedOn,
                CreatedBy = value.CreatedBy,
                LastModifiedOn = value.LastModifiedOn,
                LastModifiedBy = value.LastModifiedBy
            };
        }
    }
}
