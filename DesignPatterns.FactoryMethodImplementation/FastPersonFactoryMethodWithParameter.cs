using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.FactoryMethodImplementation
{
    /// <summary>
    /// Factory method pattern with Customer paramter for FastPerson objects.
    /// </summary>
    public class FastPersonFactoryMethodWithParameter :
        FactoryMethodWithParameter<ICustomer, FastPerson>
    {
        /// <summary>
        /// Creates a new instance of FastPerson based on
        /// the customer paramter.
        /// </summary>
        /// <param name="value">The Customer to create as FastPerson.</param>
        /// <returns>A new instance of FastPerson based on the customer data.</returns>
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
