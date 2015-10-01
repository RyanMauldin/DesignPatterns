using System;
using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    public class PersonDisplayWalkBehavior :
        PersonDisplayBehavior
    {
        public PersonDisplayWalkBehavior(StringBuilder builder)
            : base(builder)
        {

        }

        public override void Behave(IPerson target)
        {
            lock (Builder)
            {
                Builder.AppendFormat(
                    "{0} {1} is a person walking {2:N2} mph.\n",
                    target.FirstName,
                    target.LastName,
                    Math.Round(target.VelocityMultiplier * 2m, 2, MidpointRounding.AwayFromZero));
            }
        }
    }
}
