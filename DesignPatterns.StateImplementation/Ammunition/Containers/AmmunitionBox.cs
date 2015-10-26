using DesignPatterns.StateImplementation.Ammunition.Interfaces;

namespace DesignPatterns.StateImplementation.Ammunition.Containers
{
    public class AmmunitionBox :
        AmmunitionContainer
    {
        public AmmunitionBox(
            IAmmunition ammunition,
            int ammunitionCount,
            int maxiumAmmunitionCount) :
                base (
                    ammunition,
                    ammunitionCount,
                    maxiumAmmunitionCount)
        {

        }

        public override string Name
        {
            get { return "Ammunition Box"; }
        }

        public override string Description
        {
            get { return "A box to hold ammunition."; }
        }

        public override decimal Weight
        {
            get { return 1m; }
        }
    }
}
