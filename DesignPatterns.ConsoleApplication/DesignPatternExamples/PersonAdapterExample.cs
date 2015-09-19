using System.Linq;
using System.Text;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;
using Newtonsoft.Json;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    public class PersonAdapterExample : DesignPatternExample
    {
        private readonly IAdapter<ICustomer, IPerson> _personAdapter;

        public PersonAdapterExample(
            IAdapter<ICustomer, IPerson> personAdapter)
        {
            _personAdapter = personAdapter;
        }

        public override void Run(StringBuilder builder)
        {
            base.Run(builder);

            var persons = MockData.Customers.
                Select(p => _personAdapter.Adapt(p)).
                ToList();

            builder.AppendLine(
                JsonConvert.SerializeObject(
                    persons, Formatting.Indented));
        }
    }
}
