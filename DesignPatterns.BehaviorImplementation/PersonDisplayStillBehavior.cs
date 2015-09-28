using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    public class PersonDisplayStillBehavior :
        PersonDisplayBehavior
    {
        public override void BehaveDebug(IPerson target, StringBuilder builder)
        {
            builder.AppendFormat("{0} {1} is a person standing still.\n",
                target.FirstName,
                target.LastName);
        }
    }
}
