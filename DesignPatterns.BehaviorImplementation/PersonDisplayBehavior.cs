using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    /// <summary>
    /// The base PersonDisplayBehavior.
    /// </summary>
    public abstract class PersonDisplayBehavior :
        Behavior<IPerson>
    {
        /// <summary>
        /// Used to gather output from the sample display behaviors.
        /// </summary>
        protected StringBuilder Builder { get; set; }

        /// <summary>
        /// The constructor to use for this set of Behaviors.
        /// </summary>
        /// <param name="builder">Used to gather output from the sample display behaviors.</param>
        protected PersonDisplayBehavior(StringBuilder builder)
        {
            Builder = builder;
        }
    }
}
