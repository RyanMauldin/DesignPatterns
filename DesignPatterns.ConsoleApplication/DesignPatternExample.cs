using System.Text;
using DesignPatterns.ConsoleApplication.Interfaces;

namespace DesignPatterns.ConsoleApplication
{
    public abstract class DesignPatternExample : IDesignPatternExample
    {
        public virtual void GetHeader(StringBuilder builder)
        {
            builder.AppendFormat("{0} results:\n\n", this.GetType().Name);
        }

        public virtual void Run(StringBuilder builder)
        {
            GetHeader(builder);
        }
    }
}
