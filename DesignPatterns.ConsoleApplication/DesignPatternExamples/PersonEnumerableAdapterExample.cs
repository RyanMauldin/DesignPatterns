using System.Collections.Generic;
using System.Text;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;
using Newtonsoft.Json;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    /// <summary>
    /// The Person Enumerable Adapter Example.
    /// </summary>
    public class PersonEnumerableAdapterExample :
        DesignPatternExample
    {
        private readonly IAdapter<IEnumerable<ICustomer>, IEnumerable<IPerson>> _adapter;

        public PersonEnumerableAdapterExample(
            IAdapter<IEnumerable<ICustomer>, IEnumerable<IPerson>> adapter)
        {
            _adapter = adapter;
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
                        _adapter.Adapt(MockData.Customers),
                        Formatting.Indented));
            }
        }
    }
}
