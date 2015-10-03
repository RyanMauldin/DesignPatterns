using System.Text;
using DesignPatterns.Interfaces;
using DesignPatterns.Models;
using Newtonsoft.Json;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    /// <summary>
    /// The Fast Person Factory Method Example.
    /// </summary>
    public class FastPersonFactoryMethodExample :
        DesignPatternExample
    {
        private readonly IFactoryMethod<FastPerson> _factoryMethod;

        public FastPersonFactoryMethodExample(
            IFactoryMethod<FastPerson> factoryMethod)
        {
            _factoryMethod = factoryMethod;
        }

        /// <summary>
        /// The run method, runs your example design pattern
        /// and gathers output for the Console in the
        /// passed in StringBuilder.
        /// </summary>
        /// <param name="builder">The StringBuilder to gather output for the Console.</param>
        public override void Run(StringBuilder builder)
        {
            base.Run(builder);
            lock (builder)
            {
                builder.AppendLine(
                    JsonConvert.SerializeObject(
                        _factoryMethod.Create(),
                        Formatting.Indented));
            }
        }
    }
}
