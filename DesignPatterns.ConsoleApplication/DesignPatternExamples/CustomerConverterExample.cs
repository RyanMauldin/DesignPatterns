using System.Linq;
using System.Text;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;
using Newtonsoft.Json;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    /// <summary>
    /// The Customer Converter Example.
    /// </summary>
    public class CustomerConverterExample :
        DesignPatternExample
    {
        private readonly IConverter<IPerson, ICustomer> _converter;

        public CustomerConverterExample(
            IConverter<IPerson, ICustomer> converter)
        {
            _converter = converter;
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
                        MockData.Customers.Select(p => _converter.Convert(p)),
                        Formatting.Indented));
            }
        }
    }
}
