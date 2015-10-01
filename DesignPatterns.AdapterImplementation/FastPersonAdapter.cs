using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.AdapterImplementation
{
    /// <summary>
    /// Adapts an ICustomer interface into an IPerson interface
    /// by creating a new FastPerson object.
    /// </summary>
    public class FastPersonAdapter :
        Adapter<ICustomer, IPerson>
    {
        /// <summary>
        /// Adapts an ICustomer interface into an IPerson interface
        /// by creating a new FastPerson object.
        /// </summary>
        /// <param name="value">The input ICustomer object to adapt.</param>
        /// <returns>An IPerson interface created as FastPerson, or null if passed a null object.</returns>
        public override IPerson Adapt(ICustomer value)
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
