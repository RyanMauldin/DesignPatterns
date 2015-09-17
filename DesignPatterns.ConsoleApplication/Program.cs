using System;
using System.Text;

namespace DesignPatterns.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            AdapterConsoleRunner.GetHeader(builder);
            AdapterConsoleRunner.Run(builder);
            Console.WriteLine(builder.ToString());
            Console.WriteLine("\nPress any key to exit the application...");
            Console.ReadKey(true);
        }
    }
}
