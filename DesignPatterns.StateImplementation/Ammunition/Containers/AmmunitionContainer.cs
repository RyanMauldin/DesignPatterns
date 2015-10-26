using DesignPatterns.StateImplementation.Ammunition.Containers.Interfaces;
using DesignPatterns.StateImplementation.Ammunition.Interfaces;

namespace DesignPatterns.StateImplementation.Ammunition.Containers
{
    public abstract class AmmunitionContainer :
        IAmmunitionContainer
    {
        protected AmmunitionContainer(
            IAmmunition ammunition,
            int ammunitionCount,
            int maxiumAmmunitionCount)
        {
            Ammunition = ammunition;
            AmmunitionCount = ammunitionCount;
            MaxiumAmmunitionCount = maxiumAmmunitionCount;
        }

        // IItem
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract decimal Weight { get; }

        // IAmmunitionContainer
        public IAmmunition Ammunition { get; set; }
        public int AmmunitionCount { get; set; }
        public int MaxiumAmmunitionCount { get; set; }
    }
}
