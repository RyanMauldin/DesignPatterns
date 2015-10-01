using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    /// <summary>
    /// Display sample person is still to the console.
    /// </summary>
    public class PersonDisplayStillBehavior :
        PersonDisplayBehavior
    {
        public PersonDisplayStillBehavior(StringBuilder builder)
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
                    "{0} {1} is a person standing still.\n",
                    target.FirstName,
                    target.LastName);
            }
        }
    }
}
