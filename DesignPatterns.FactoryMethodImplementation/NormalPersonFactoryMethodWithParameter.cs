using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.FactoryMethodImplementation
{
    /// <summary>
    /// Factory method pattern with Customer paramter for NormalPerson objects.
    /// </summary>
    public class NormalPersonFactoryMethodWithParameter :
        FactoryMethodWithParameter<ICustomer, NormalPerson>
    {
        /// <summary>
        /// Creates a new instance of NormalPerson based on
        /// the customer paramter.
        /// </summary>
        /// <param name="value">The Customer to create as NormalPerson.</param>
        /// <returns>A new instance of NormalPerson based on the customer data.</returns>
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
