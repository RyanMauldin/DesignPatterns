using System;

namespace DesignPatterns.Models.Interfaces
{
    public interface IEntity : IEntityIdentity
    {
        DateTime CreatedOn { get; set; }
        string CreatedBy { get; set; }
        DateTime LastModifiedOn { get; set; }
        string LastModifiedBy { get; set; }
    }
}
