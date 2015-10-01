using System.Linq;
using System.Text;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;
using Newtonsoft.Json;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    /// <summary>
    /// The Customer Adapter Example.
    /// </summary>
    public class CustomerAdapterExample : DesignPatternExample
    {
        private readonly IAdapter<IPerson, ICustomer> _adapter;

        public CustomerAdapterExample(
            IAdapter<IPerson, ICustomer> adapter)
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
                        MockData.Customers.Select(p => _adapter.Adapt(p)),
                        Formatting.Indented));
            }
        }
    }
}
