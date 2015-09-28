using System;
using System.Text;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.Models
{
    public abstract class Person : IPerson
    {
        protected Person()
        {
            VelocityMultiplier = 1m;
        }

        protected Person(
            IBehavior<IPerson> displayIdleBehavior,
            IBehavior<IPerson> displayStillBehavior,
            IBehavior<IPerson> displayRunBehavior,
            IBehavior<IPerson> displayWalkBehavior,
            IBehavior<IPerson> displayDriveBehavior)
        {
            DisplayIdleBehavior = displayIdleBehavior;
            DisplayStillBehavior = displayStillBehavior;
            DisplayRunBehavior = displayRunBehavior;
            DisplayWalkBehavior = displayWalkBehavior;
            DisplayDriveBehavior = displayDriveBehavior;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal VelocityMultiplier { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }

        public IBehavior<IPerson> DisplayIdleBehavior { get; set; }
        public IBehavior<IPerson> DisplayStillBehavior { get; set; }
        public IBehavior<IPerson> DisplayRunBehavior { get; set; }
        public IBehavior<IPerson> DisplayWalkBehavior { get; set; }
        public IBehavior<IPerson> DisplayDriveBehavior { get; set; }

        public virtual void Idle(StringBuilder builder)
        {
            DisplayIdleBehavior.BehaveDebug(this, builder);
        }

        public virtual void Still(StringBuilder builder)
        {
            DisplayStillBehavior.BehaveDebug(this, builder);
        }

        public virtual void Walk(StringBuilder builder)
        {
            DisplayWalkBehavior.BehaveDebug(this, builder);
        }

        public virtual void Run(StringBuilder builder)
        {
            DisplayRunBehavior.BehaveDebug(this, builder);
        }

        public virtual void Drive(StringBuilder builder)
        {
            DisplayDriveBehavior.BehaveDebug(this, builder);
        }
    }
}
