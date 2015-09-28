using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    public class PersonDisplayIdleBehavior :
        PersonDisplayBehavior
    {
        public override void BehaveDebug(IPerson target, StringBuilder builder)
        {
            builder.AppendFormat("{0} {1} is a person that is idle.\n",
                target.FirstName,
                target.LastName);
        }
    }
}
