using System.Collections.Generic;
using System.Text;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;
using Newtonsoft.Json;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    /// <summary>
    /// The Customer Enumerable Converter Example.
    /// </summary>
    public class CustomerEnumerableConverterExample :
        DesignPatternExample
    {
        private readonly IConverter<IEnumerable<IPerson>, IEnumerable<ICustomer>> _converter;

        public CustomerEnumerableConverterExample(
            IConverter<IEnumerable<IPerson>, IEnumerable<ICustomer>>  converter)
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
