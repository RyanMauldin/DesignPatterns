namespace DesignPatterns.StateImplementation.Ammunition.Containers
{
    public class AmmunitionMagazine :
        AmmunitionContainer
    {
        public AmmunitionMagazine(
            int ammunitionCount,
            int maxiumAmmunitionCount) :
                base (ammunitionCount, maxiumAmmunitionCount)
        {

        }

        public override string Name
        {
            get { return "Ammunition Magazine"; }
        }

        public override string Description
        {
            // http://www.gunsandammo.com/gun-culture/9-misused-gun-terms/
            get { return "A spring loaded catrige feeder. Feeds bullets into gun chamber."; }
        }

        public override decimal Weight
        {
            get { return .35m; }
        }
    }
}
