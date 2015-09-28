using System;
using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    public class PersonDisplayWalkBehavior :
        PersonDisplayBehavior
    {
        public override void BehaveDebug(IPerson target, StringBuilder builder)
        {
            builder.AppendFormat("{0} {1} is a person walking {2:N2} mph.\n",
                target.FirstName,
                target.LastName,
                Math.Round(target.VelocityMultiplier * 2m, 2, MidpointRounding.AwayFromZero));
        }
    }
}
