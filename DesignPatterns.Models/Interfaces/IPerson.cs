using DesignPatterns.Interfaces;

namespace DesignPatterns.Models.Interfaces
{
    public interface IPerson : IEntity
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        decimal VelocityMultiplier { get; set; }

        IBehavior<IPerson> DisplayIdleBehavior { get; set; }
        IBehavior<IPerson> DisplayStillBehavior { get; set; }
        IBehavior<IPerson> DisplayWalkBehavior { get; set; }
        IBehavior<IPerson> DisplayRunBehavior { get; set; }
        IBehavior<IPerson> DisplayDriveBehavior { get; set; }

        void Idle();
        void Still();
        void Walk();
        void Run();
        void Drive();
    }
}
