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

            // Adapter Example
            var adapterExample = container.Resolve<IDesignPatternExample>("AdapterExample");
            adapterExample.GetHeader(builder);
            adapterExample.Run(builder);

            // Show output from examples...
            Console.WriteLine(builder.ToString());

            Console.WriteLine("\nPress any key to exit the application...");
            Console.ReadKey(true);
        }
    }
}
