using DesignPatterns.StateImplementation.Ammunition.Interfaces;
using DesignPatterns.StateImplementation.Interfaces;

namespace DesignPatterns.StateImplementation.Ammunition.Containers.Interfaces
{
    /// <summary>
    /// An interface to represent a container for ammunition.
    /// The ammunition does not represent physical ammunition
    /// in-game, however a count of a type of ammunition for
    /// the container and its count limit.
    /// </summary>
    public interface IAmmunitionContainer :
        IItem
    {
        /// <summary>
        /// Ammunition this container holds.
        /// </summary>
        IAmmunition Ammunition { get; set; }

        /// <summary>
        /// The current amount of ammuntion in the container.
        /// </summary>
        int AmmunitionCount { get; set; }

        /// <summary>
        /// The maximum amount of ammuntion the container can hold.
        /// </summary>
        int MaxiumAmmunitionCount { get; set; }
    }
}
