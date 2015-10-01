using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    public abstract class PersonDisplayBehavior :
        Behavior<IPerson>
    {
        protected StringBuilder Builder { get; set; }

        protected PersonDisplayBehavior(StringBuilder builder)
        {
            lock (builder)
            {
                Builder = builder;
            }
        }
    }
}
