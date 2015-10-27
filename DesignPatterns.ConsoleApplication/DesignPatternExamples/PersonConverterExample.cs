using System.Linq;
using System.Text;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;
using Newtonsoft.Json;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    /// <summary>
    /// The Person Converter Example.
    /// </summary>
    public class PersonConverterExample :
        DesignPatternExample
    {
        private readonly IConverter<ICustomer, IPerson> _converter;

        public PersonConverterExample(
            IConverter<ICustomer, IPerson> converter)
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
