using System;

namespace DesignPatterns.Models.Interfaces
{
    /// <summary>
    /// Generic code first entities to use in a Repository
    /// Pattern may use something similar used in every
    /// Code First style Entity. However, this alone
    /// will not achieve all auditing needs. Create
    /// a specific repo just for auditing, but apply
    /// this to every entity in your Pocos for
    /// data clarification needs.
    /// </summary>
    public interface IEntity : IEntityIdentity
    {
        DateTime CreatedOn { get; set; }
        string CreatedBy { get; set; }
        DateTime LastModifiedOn { get; set; }
        string LastModifiedBy { get; set; }
    }
}
