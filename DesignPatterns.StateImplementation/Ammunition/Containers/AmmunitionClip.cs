using DesignPatterns.StateImplementation.Ammunition.Interfaces;

namespace DesignPatterns.StateImplementation.Ammunition.Containers
{
    /// <summary>
    /// A class to represent a clip of ammunition.
    /// The ammunition does not represent physical ammunition
    /// in-game, however a count of a type of ammunition for
    /// the container and its count limit.
    /// // http://www.gunsandammo.com/gun-culture/9-misused-gun-terms/
    /// </summary>
    public class AmmunitionClip :
        AmmunitionContainer
    {
        /// <summary>
        /// Specific constructor needed for all Ammunition Containers.
        /// </summary>
        /// <param name="ammunition">Ammunition this container holds.</param>
        /// <param name="ammunitionCount">The current amount of ammuntion in the container.</param>
        /// <param name="maxiumAmmunitionCount">The maximum amount of ammuntion the container can hold.</param>
        public AmmunitionClip(
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
            get { return "Clip"; }
        }

        /// <summary>
        /// The description of an item.
        /// </summary>
        public override string Description
        {
            get { return "Clips feed some magazines. Generally they have no spring."; }
        }

        /// <summary>
        /// The weight of an item. Some items may not weigh anything.
        /// </summary>
        public override decimal Weight
        {
            get { return .25m; }
        }

        #endregion
    }
}
