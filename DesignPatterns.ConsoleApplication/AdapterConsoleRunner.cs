using System.Text;
using DesignPatterns.AdapterImplementation;

namespace DesignPatterns.ConsoleApplication
{
    public static class AdapterConsoleRunner
    {
        public static void GetHeader(StringBuilder builder)
        {
            builder.AppendLine("Adapter pattern results: \n");
        }

        public static void Run(StringBuilder builder)
        {
            var personAdapter = new PersonAdapter();
            foreach (var customer in MochData.Customers)
            {
                var person = personAdapter.Adapt(customer);
                builder.AppendFormat("[ FirstName = {0}, MiddleName = {1}, LastName = {2}, Email = {3} ]\n",
                    person.FirstName, person.MiddleName, person.LastName, person.Email);
            }
        }
    }
}
