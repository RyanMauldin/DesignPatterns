using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.FactoryMethodImplementation
{
    public class NormalPersonFactoryMethodWithParameter :
        FactoryMethodWithParameter<ICustomer, NormalPerson>
    {
        public override NormalPerson Create(ICustomer value)
        {
            if (value == null)
                return null;

            return new NormalPerson
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
