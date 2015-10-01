using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    public class PersonDisplayStillBehavior :
        PersonDisplayBehavior
    {
        public PersonDisplayStillBehavior(StringBuilder builder)
            : base(builder)
        {

        }

        public override void Behave(IPerson target)
        {
            lock (Builder)
            {
                Builder.AppendFormat(
                    "{0} {1} is a person standing still.\n",
                    target.FirstName,
                    target.LastName);
            }
        }
    }
}
