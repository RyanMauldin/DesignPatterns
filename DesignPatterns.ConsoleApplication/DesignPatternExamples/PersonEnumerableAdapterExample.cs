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
        private readonly IAdapter<IEnumerable<ICustomer>, IEnumerable<IPerson>> _adapter;

        public PersonEnumerableAdapterExample(
            IAdapter<IEnumerable<ICustomer>, IEnumerable<IPerson>> adapter)
        {
            _adapter = adapter;
        }

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
