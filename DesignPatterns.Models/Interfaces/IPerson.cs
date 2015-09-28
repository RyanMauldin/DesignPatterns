using System.Text;
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

        void Idle(StringBuilder builder);
        void Still(StringBuilder builder);
        void Walk(StringBuilder builder);
        void Run(StringBuilder builder);
        void Drive(StringBuilder builder);
    }
}
