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
        private readonly IAdapter<ICustomer, IPerson> _adapter;

        public PersonAdapterExample(
            IAdapter<ICustomer, IPerson> adapter)
        {
            _adapter = adapter;
        }

        public override void Run(StringBuilder builder)
        {
            base.Run(builder);
            builder.AppendLine(
                JsonConvert.SerializeObject(
                    MockData.Customers.Select(p => _adapter.Adapt(p)),
                    Formatting.Indented));
        }
    }
}
