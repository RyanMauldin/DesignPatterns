using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.ConverterImplementation
{
    /// <summary>
    /// Convert an ICustomer interface into an IPerson interface
    /// by creating a new NormalPerson object.
    /// </summary>
    public class NormalPersonConverter :
        Converter<ICustomer, IPerson>
    {
        /// <summary>
        /// Converts an ICustomer interface into an IPerson interface
        /// by creating a new NormalPerson object.
        /// </summary>
        /// <param name="value">The input ICustomer object to convert.</param>
        /// <returns>An IPerson interface created as NormalPerson, or null if passed a null object.</returns>
        public override IPerson Convert(ICustomer value)
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
