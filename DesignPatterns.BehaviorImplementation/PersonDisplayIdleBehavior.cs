using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    public class PersonDisplayIdleBehavior :
        PersonDisplayBehavior
    {
        public PersonDisplayIdleBehavior(StringBuilder builder)
            : base(builder)
        {

        }

        public override void Behave(IPerson target)
        {
            lock (Builder)
            {
                Builder.AppendFormat(
                    "{0} {1} is a person that is idle.\n",
                    target.FirstName,
                    target.LastName);
            }
        }
    }
}
