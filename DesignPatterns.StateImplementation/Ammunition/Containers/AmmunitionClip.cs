using DesignPatterns.StateImplementation.Ammunition.Interfaces;

namespace DesignPatterns.StateImplementation.Ammunition.Containers
{
    public class AmmunitionClip :
        AmmunitionContainer
    {
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

        public override string Name
        {
            get { return "Clip"; }
        }

        public override string Description
        {
            // http://www.gunsandammo.com/gun-culture/9-misused-gun-terms/
            get { return "Clips feed some magazines. Generally they have no spring."; }
        }

        public override decimal Weight
        {
            get { return .25m; }
        }
    }
}
