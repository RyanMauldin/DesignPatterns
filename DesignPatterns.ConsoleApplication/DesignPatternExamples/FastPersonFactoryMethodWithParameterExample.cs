using System.Linq;
using System.Text;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.Interfaces;
using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;
using Newtonsoft.Json;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    /// <summary>
    /// The Fast Person Factory Method With Parameter Example.
    /// </summary>
    public class FastPersonFactoryMethodWithParameterExample :
        DesignPatternExample
    {
        private readonly IFactoryMethodWithParameter<ICustomer, FastPerson> _factoryMethodWithParameter;

        public FastPersonFactoryMethodWithParameterExample(
            IFactoryMethodWithParameter<ICustomer, FastPerson> factoryMethodWithParameter)
        {
            _factoryMethodWithParameter = factoryMethodWithParameter;
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
                        MockData.Customers.Select(p => _factoryMethodWithParameter.Create(p)),
                        Formatting.Indented));
            }
        }
    }
}
