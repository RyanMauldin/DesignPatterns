using System.Collections.Generic;
using System.Text;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;
using Newtonsoft.Json;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    public class CustomerEnumerableAdapterExample : DesignPatternExample
    {
        private readonly IAdapter<IEnumerable<IPerson>, IEnumerable<ICustomer>> _adapter;

        public CustomerEnumerableAdapterExample(
            IAdapter<IEnumerable<IPerson>, IEnumerable<ICustomer>> adapter)
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
