namespace DesignPatterns.StateImplementation.Interfaces
{
    /// <summary>
    /// Every item in a video game could impement
    /// the following example interface.
    /// </summary>
    public interface IItem
    {
        /// <summary>
        /// The common name of an item.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The description of an item.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The weight of an item. Some items may not weigh anything.
        /// </summary>
        decimal Weight { get; }
    }
}
