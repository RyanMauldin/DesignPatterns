using System;

namespace DesignPatterns.Models.Interfaces
{
    public interface IEntity : IEntityIdentity
    {
        DateTime CreateOn { get; set; }
        DateTime LastModifiedOn { get; set; }
    }
}
