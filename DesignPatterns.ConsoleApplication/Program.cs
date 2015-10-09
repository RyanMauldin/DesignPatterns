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

            AdapterExamples(container, builder);
            BehaviorExamples(container, builder);
            FactoryMethodExamples(container, builder);

            // Show output from examples...
            Console.Write(builder.ToString());
            Console.Write("Press any key to exit the application: ");
            Console.ReadKey(true);
        }

        private static void AdapterExamples(IUnityContainer container, StringBuilder builder)
        {
            // Person Adapter Example
            var personAdapterExample = container.Resolve<IDesignPatternExample>("PersonAdapterExample");
            personAdapterExample.Run(builder);

            builder.AppendLine();

            // Person Enumerable Adapter Example
            var personEnumerableAdapterExample = container.Resolve<IDesignPatternExample>("PersonEnumerableAdapterExample");
            personEnumerableAdapterExample.Run(builder);

            builder.AppendLine();

            // Customer Adapter Example
            var customerAdapterExample = container.Resolve<IDesignPatternExample>("CustomerAdapterExample");
            customerAdapterExample.Run(builder);

            builder.AppendLine();

            // Customer Enumerable Adapter Example
            var customerEnumerableAdapterExample = container.Resolve<IDesignPatternExample>("CustomerEnumerableAdapterExample");
            customerEnumerableAdapterExample.Run(builder);

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
    }
}
