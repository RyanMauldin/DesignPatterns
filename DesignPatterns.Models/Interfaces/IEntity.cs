using System;

namespace DesignPatterns.Models.Interfaces
{
    public interface IEntity : IEntityIdentity
    {
        DateTime CreatedOn { get; set; }
        DateTime LastModifiedOn { get; set; }
    }
}
