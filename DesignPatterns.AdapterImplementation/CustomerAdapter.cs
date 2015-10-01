using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    /// <summary>
    /// Adapts an IPerson interface into an ICustomer interface
    /// by creating a new Customer object.
    /// </summary>
    public class CustomerAdapter :
        Adapter<IPerson, ICustomer>
    {
        /// <summary>
        /// Adapts an IPerson interface into an ICustomer interface
        /// by creating a new Customer object.
        /// </summary>
        /// <param name="value">The input IPerson object to adapt.</param>
        /// <returns>An ICustomer interface created as Customer, or null if passed a null object.</returns>
        public override ICustomer Adapt(IPerson value)
        {
            if (value == null)
                return null;

            return new Customer
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
