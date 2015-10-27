using DesignPatterns.StateImplementation.Ammunition.Containers.Interfaces;
using DesignPatterns.StateImplementation.Ammunition.Interfaces;

namespace DesignPatterns.StateImplementation.Ammunition.Containers
{
    /// <summary>
    /// An abstract class to represent a container for ammunition.
    /// The ammunition does not represent physical ammunition
    /// in-game, however a count of a type of ammunition for
    /// the container and its count limit.
    /// </summary>
    public abstract class AmmunitionContainer :
        IAmmunitionContainer
    {
        /// <summary>
        /// Specific constructor needed for all Ammunition Containers.
        /// </summary>
        /// <param name="ammunition">Ammunition this container holds.</param>
        /// <param name="ammunitionCount">The current amount of ammuntion in the container.</param>
        /// <param name="maxiumAmmunitionCount">The maximum amount of ammuntion the container can hold.</param>
        protected AmmunitionContainer(
            IAmmunition ammunition,
            int ammunitionCount,
            int maxiumAmmunitionCount)
        {
            Ammunition = ammunition;
            AmmunitionCount = ammunitionCount;
            MaxiumAmmunitionCount = maxiumAmmunitionCount;
        }

        #region IItem

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

        #endregion

        #region IAmmunitionContainer

        /// <summary>
        /// Ammunition this container holds.
        /// </summary>
        public IAmmunition Ammunition { get; set; }

        /// <summary>
        /// The current amount of ammuntion in the container.
        /// </summary>
        public int AmmunitionCount { get; set; }

        /// <summary>
        /// The maximum amount of ammuntion the container can hold.
        /// </summary>
        public int MaxiumAmmunitionCount { get; set; }

        #endregion
    }
}
