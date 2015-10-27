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
            var builder = container.Resolve<StringBuilder>("ExampleConsoleOutput");

            // Comment out methods as needed as not all of them will show in default console.
            // One could also turn the StringBuilder output into a file.
            ConverterExamples(container, builder);
            Console.Write(builder.ToString());
            builder.Clear();
            BehaviorExamples(container, builder);
            Console.Write(builder.ToString());
            builder.Clear();
            FactoryMethodExamples(container, builder);
            Console.Write(builder.ToString());
            builder.Clear();
            CommandPatternExamples(container, builder);
            Console.Write(builder.ToString());
            builder.Clear();
            StatePatternExamples(container, builder);
            Console.Write(builder.ToString());
            builder.Clear();

            // Show output from examples...
            
            Console.Write("Press any key to exit the application: ");
            Console.ReadKey(true);
        }

        private static void ConverterExamples(IUnityContainer container, StringBuilder builder)
        {
            // Person Converter Example
            var personConverterExample = container.Resolve<IDesignPatternExample>("PersonConverterExample");
            personConverterExample.Run(builder);

            builder.AppendLine();

            // Person Enumerable Converter Example
            var personEnumerableConverterExample = container.Resolve<IDesignPatternExample>("PersonEnumerableConverterExample");
            personEnumerableConverterExample.Run(builder);

            builder.AppendLine();

            // Customer Converter Example
            var customerConverterExample = container.Resolve<IDesignPatternExample>("CustomerConverterExample");
            customerConverterExample.Run(builder);

            builder.AppendLine();

            // Customer Enumerable Converter Example
            var customerEnumerableConverterExample = container.Resolve<IDesignPatternExample>("CustomerEnumerableConverterExample");
            customerEnumerableConverterExample.Run(builder);

            builder.AppendLine();
        }

        private static void BehaviorExamples(IUnityContainer container, StringBuilder builder)
        {
            // Normal Person Behavior Example
            var normalPersonBehaviorExample = container.Resolve<IDesignPatternExample>("NormalPersonBehaviorExample");
            normalPersonBehaviorExample.Run(builder);

            builder.AppendLine();

            // Fast Person Behavior Example
            var fastPersonBehaviorExample = container.Resolve<IDesignPatternExample>("FastPersonBehaviorExample");
            fastPersonBehaviorExample.Run(builder);

            builder.AppendLine();
        }
        
        private static void FactoryMethodExamples(IUnityContainer container, StringBuilder builder)
        {
            // Fast Person Factory Method Example
            var fastPersonFactoryMethodExample = container.Resolve<IDesignPatternExample>("FastPersonFactoryMethodExample");
            fastPersonFactoryMethodExample.Run(builder);

            builder.AppendLine();

            // Fast Person Factory Method With Parameter Example
            var fastPersonFactoryMethodWithParameterExample = container.Resolve<IDesignPatternExample>("FastPersonFactoryMethodWithParameterExample");
            fastPersonFactoryMethodWithParameterExample.Run(builder);

            builder.AppendLine();

            // Normal Person Factory Method Example
            var normalPersonFactoryMethodExample = container.Resolve<IDesignPatternExample>("NormalPersonFactoryMethodExample");
            normalPersonFactoryMethodExample.Run(builder);

            builder.AppendLine();

            // Normal Person Factory Method With Parameter Example
            var normalPersonFactoryMethodWithParameterExample = container.Resolve<IDesignPatternExample>("NormalPersonFactoryMethodWithParameterExample");
            normalPersonFactoryMethodWithParameterExample.Run(builder);

            builder.AppendLine();
        }
        
        private static void CommandPatternExamples(IUnityContainer container, StringBuilder builder)
        {
            // Command Pattern Example
            var commandPatternExample = container.Resolve<IDesignPatternExample>("CommandPatternExample");
            commandPatternExample.Run(builder);

            builder.AppendLine();
        }

        private static void StatePatternExamples(IUnityContainer container, StringBuilder builder)
        {
            // State Pattern Example
            var statePatternExample = container.Resolve<IDesignPatternExample>("StatePatternExample");
            statePatternExample.Run(builder);

            builder.AppendLine();
        }
    }
}
