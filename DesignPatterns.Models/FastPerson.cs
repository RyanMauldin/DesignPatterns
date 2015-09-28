using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.Models
{
    public class FastPerson : Person
    {
        private const decimal DefaultVelocityMultiplier = 2m;

        public FastPerson()
        {
            VelocityMultiplier = DefaultVelocityMultiplier;
        }

        public FastPerson(
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
