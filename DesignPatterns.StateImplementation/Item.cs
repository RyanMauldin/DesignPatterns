using DesignPatterns.StateImplementation.Interfaces;

namespace DesignPatterns.StateImplementation
{
    /// <summary>
    /// Every item in a video game could base
    /// off the following example abstract class.
    /// </summary>
    public abstract class Item :
        IItem
    {
        /// <summary>
        /// The common name of an item.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The description of an item.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The weight of an item. Some items may not weigh anything.
        /// </summary>
        public abstract decimal Weight { get; }
    }
}
