using System.Text;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.ConsoleApplication.Interfaces;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    public class PersonAdapterExample : IDesignPatternExample
    {
        private readonly IAdapter<ICustomer, IPerson> _personAdapter;

        public PersonAdapterExample(
            IAdapter<ICustomer, IPerson> personAdapter)
        {
            _personAdapter = personAdapter;
        }

        public void GetHeader(StringBuilder builder)
        {
            builder.AppendLine("Adapter pattern results: \n");
        }

        public void Run(StringBuilder builder)
        {
            foreach (var customer in MockData.Customers)
            {
                var person = _personAdapter.Adapt(customer);
                builder.AppendFormat("[ FirstName = {0}, MiddleName = {1}, LastName = {2}, Email = {3} ]\n",
                    person.FirstName, person.MiddleName, person.LastName, person.Email);
            }
        }
    }
}
