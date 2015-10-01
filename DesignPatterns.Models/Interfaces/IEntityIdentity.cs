namespace DesignPatterns.Models.Interfaces
{
    /// <summary>
    /// I typically do all my database coding this way,
    /// using the Identity pattern. This could be a string
    /// or GUID, up to your usage and your data store.
    /// </summary>
    public interface IEntityIdentity
    {
        int Id { get; set; }
    }
}
