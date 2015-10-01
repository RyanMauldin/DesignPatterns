using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    /// <summary>
    /// Display sample person is idle to the console.
    /// </summary>
    public class PersonDisplayIdleBehavior :
        PersonDisplayBehavior
    {
        public PersonDisplayIdleBehavior(StringBuilder builder)
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
                    "{0} {1} is a person that is idle.\n",
                    target.FirstName,
                    target.LastName);
            }
        }
    }
}
