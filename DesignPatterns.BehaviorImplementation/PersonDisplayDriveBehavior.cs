using System;
using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    /// <summary>
    /// Display sample person driving speed to the console.
    /// </summary>
    public class PersonDisplayDriveBehavior :
        PersonDisplayBehavior
    {
        public PersonDisplayDriveBehavior(StringBuilder builder)
            : base(builder)
        {

        }

        /// <summary>
        /// The sample behavior.
        /// </summary>
        /// <param name="target">The target or parent object if needed.</param>
        public override void Behave(IPerson target)
        {
            lock (Builder)
            {
                Builder.AppendFormat(
                    "{0} {1} is a person driving {2:N2} mph.\n",
                    target.FirstName,
                    target.LastName,
                    Math.Round(target.VelocityMultiplier * 40m, 2, MidpointRounding.AwayFromZero));
            }
            
        }
    }
}
