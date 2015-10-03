using System.Text;
using DesignPatterns.Interfaces;
using DesignPatterns.Models;
using Newtonsoft.Json;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    /// <summary>
    /// The Normal Person Factory Method Example.
    /// </summary>
    public class NormalPersonFactoryMethodExample :
        DesignPatternExample
    {
        private readonly IFactoryMethod<NormalPerson> _factoryMethod;

        public NormalPersonFactoryMethodExample(
            IFactoryMethod<NormalPerson> factoryMethod)
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
