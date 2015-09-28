using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.Models
{
    public class NormalPerson : Person
    {
        private const decimal DefaultVelocityMultiplier = 1m;

        public NormalPerson()
        {
            VelocityMultiplier = DefaultVelocityMultiplier;
        }

        public NormalPerson(
            IBehavior<IPerson> displayIdleBehavior,
            IBehavior<IPerson> displayStillBehavior,
            IBehavior<IPerson> displayRunBehavior,
            IBehavior<IPerson> displayWalkBehavior,
            IBehavior<IPerson> displayDriveBehavior) :
            base(
                displayIdleBehavior,
                displayStillBehavior,
                displayRunBehavior,
                displayWalkBehavior,
                displayDriveBehavior)
        {
            VelocityMultiplier = DefaultVelocityMultiplier;
        }
    }
}
