using System.Text;
using DesignPatterns.ConsoleApplication.Interfaces;

namespace DesignPatterns.ConsoleApplication
{
    /// <summary>
    /// All Design Pattern Example code in this application
    /// can derive from this interface. Do not forget to
    /// register your examples in the App_Start/UnityConfig.cs
    /// file. This is a base clase that automatically prints
    /// the class name to the console for each example.
    /// Override theh Run method to achieve your own examples.
    /// </summary>
    public abstract class DesignPatternExample : IDesignPatternExample
    {
        /// <summary>
        /// This method prints the Class name to a string builder. This method
        /// is automatically called when you call the Run method. Override
        /// this if you need a custom header.
        /// </summary>
        /// <param name="builder">The StringBuilder to gather output for the Console.</param>
        public virtual void GetHeader(StringBuilder builder)
        {
            lock (builder)
            {
                builder.AppendFormat(
                    "{0} results:\n\n",
                    GetType().Name);
            }
        }

        /// <summary>
        /// The run method, runs your example design pattern
        /// and gathers output for the Console in the
        /// passed in StringBuilder.
        /// </summary>
        /// <param name="builder">The StringBuilder to gather output for the Console.</param>
        public virtual void Run(StringBuilder builder)
        {
            GetHeader(builder);
        }
    }
}
