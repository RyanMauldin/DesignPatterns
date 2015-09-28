using System;
using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    public class PersonDisplayRunBehavior :
        PersonDisplayBehavior
    {
        public override void BehaveDebug(IPerson target, StringBuilder builder)
        {
            builder.AppendFormat("{0} {1} is a person running {2:N2} mph.\n",
                target.FirstName,
                target.LastName,
                Math.Round(target.VelocityMultiplier * 5m, 2, MidpointRounding.AwayFromZero));
        }
    }
}
