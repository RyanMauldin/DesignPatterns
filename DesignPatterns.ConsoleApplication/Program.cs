using System;
using System.Text;
using DesignPatterns.ConsoleApplication.Interfaces;
using Microsoft.Practices.Unity;

namespace DesignPatterns.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = UnityConfig.GetConfiguredContainer();
            var builder = new StringBuilder();

            // Person Adapter Example
            var personAdapterExample = container.Resolve<IDesignPatternExample>("PersonAdapterExample"); ;
            personAdapterExample.Run(builder);

            builder.AppendLine();

            // Person Enumerable Adapter Example
            var personEnumerableAdapterExample = container.Resolve<IDesignPatternExample>("PersonEnumerableAdapterExample");
            personEnumerableAdapterExample.Run(builder);

            builder.AppendLine();

            // Customer Adapter Example
            var customerAdapterExample = container.Resolve<IDesignPatternExample>("CustomerAdapterExample"); ;
            customerAdapterExample.Run(builder);

            builder.AppendLine();

            // Customer Enumerable Adapter Example
            var customerEnumerableAdapterExample = container.Resolve<IDesignPatternExample>("CustomerEnumerableAdapterExample");
            customerEnumerableAdapterExample.Run(builder);

            builder.AppendLine();

            // Show output from examples...
            Console.WriteLine(builder.ToString());

            Console.Write("Press any key to exit the application: ");
            Console.ReadKey(true);
        }
    }
}
