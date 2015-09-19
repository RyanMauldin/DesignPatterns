using System.Collections.Generic;
using System.Text;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;
using Newtonsoft.Json;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    public class PersonEnumerableAdapterExample : DesignPatternExample
    {
        private readonly IAdapter<IEnumerable<ICustomer>, IEnumerable<IPerson>> _personEnumerableAdapter;

        public PersonEnumerableAdapterExample(
            IAdapter<IEnumerable<ICustomer>, IEnumerable<IPerson>> personEnumerableAdapter)
        {
            _personEnumerableAdapter = personEnumerableAdapter;
        }

        public override void Run(StringBuilder builder)
        {
            base.Run(builder);

            var persons = _personEnumerableAdapter.
                Adapt(MockData.Customers);

            builder.AppendLine(
                JsonConvert.SerializeObject(
                    persons, Formatting.Indented));
        }
    }
}
