using System.Collections.Generic;
using System.Text;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;
using Newtonsoft.Json;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    /// <summary>
    /// The Person Enumerable Converter Example.
    /// </summary>
    public class PersonEnumerableConverterExample :
        DesignPatternExample
    {
        private readonly IConverter<IEnumerable<ICustomer>, IEnumerable<IPerson>> _converter;

        public PersonEnumerableConverterExample(
            IConverter<IEnumerable<ICustomer>, IEnumerable<IPerson>> converter)
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
                        _converter.Convert(MockData.Customers),
                        Formatting.Indented));
            }
        }
    }
}
