using System;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.Models
{
    /// <summary>
    /// Generic Person style base class for this sample project. This class
    /// would most likely be split up as partials between your poco layer and
    /// program logic layers.
    /// </summary>
    public abstract class Person : IPerson
    {
        protected Person()
        {
            VelocityMultiplier = 1m;
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

        public virtual void Idle()
        {
            DisplayIdleBehavior.Behave(this);
        }

        public virtual void Still()
        {
            DisplayStillBehavior.Behave(this);
        }

        public virtual void Walk()
        {
            DisplayWalkBehavior.Behave(this);
        }

        public virtual void Run()
        {
            DisplayRunBehavior.Behave(this);
        }

        public virtual void Drive()
        {
            DisplayDriveBehavior.Behave(this);
        }
    }
}
