using DesignPatterns.StateImplementation.Ammunition.Interfaces;

namespace DesignPatterns.StateImplementation.Ammunition.Containers
{
    /// <summary>
    /// A class to represent a magazine of ammunition.
    /// The ammunition does not represent physical ammunition
    /// in-game, however a count of a type of ammunition for
    /// the container and its count limit.
    /// // http://www.gunsandammo.com/gun-culture/9-misused-gun-terms/
    /// </summary>
    public class AmmunitionMagazine :
        AmmunitionContainer
    {
        /// <summary>
        /// Specific constructor needed for all Ammunition Containers.
        /// </summary>
        /// <param name="ammunition">Ammunition this container holds.</param>
        /// <param name="ammunitionCount">The current amount of ammuntion in the container.</param>
        /// <param name="maxiumAmmunitionCount">The maximum amount of ammuntion the container can hold.</param>
        public AmmunitionMagazine(
            IAmmunition ammunition,
            int ammunitionCount,
            int maxiumAmmunitionCount) :
            base(
                    ammunition,
                    ammunitionCount,
                    maxiumAmmunitionCount)
        {

        }

        #region IItem

        /// <summary>
        /// The common name of an item.
        /// </summary>
        public override string Name
        {
            get { return "Ammunition Magazine"; }
        }

        /// <summary>
        /// The description of an item.
        /// </summary>
        public override string Description
        {
            // http://www.gunsandammo.com/gun-culture/9-misused-gun-terms/
            get { return "A spring loaded catrige feeder. Feeds bullets into gun chamber."; }
        }

        /// <summary>
        /// The weight of an item. Some items may not weigh anything.
        /// </summary>
        public override decimal Weight
        {
            get { return .35m; }
        }

        #endregion
    }
}
