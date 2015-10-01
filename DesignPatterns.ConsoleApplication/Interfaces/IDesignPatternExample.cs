using System.Text;

namespace DesignPatterns.ConsoleApplication.Interfaces
{
    /// <summary>
    /// All Design Pattern Example code in this application
    /// can derive from this interface. Do not forget to
    /// register your examples in the App_Start/UnityConfig.cs
    /// file.
    /// </summary>
    public interface IDesignPatternExample
    {
        /// <summary>
        /// The run method, runs your example design pattern
        /// and gathers output for the Console in the
        /// passed in StringBuilder.
        /// </summary>
        /// <param name="builder">The StringBuilder to gather output for the Console.</param>
        void Run(StringBuilder builder);
    }
}