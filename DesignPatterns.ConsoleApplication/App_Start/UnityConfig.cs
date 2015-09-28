using System;
using System.Collections.Generic;
using DesignPatterns.AdapterImplementation;
using DesignPatterns.BehaviorImplementation;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.ConsoleApplication.DesignPatternExamples;
using DesignPatterns.ConsoleApplication.Interfaces;
using DesignPatterns.Interfaces;
using DesignPatterns.Models.Interfaces;
using Microsoft.Practices.Unity;

namespace DesignPatterns.ConsoleApplication
{
    public static class UnityConfig
    {
        #region Unity Container

        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return Container.Value;
        }

        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // Person Adapter Examples
            container.RegisterType(typeof(IAdapter<ICustomer, IPerson>), typeof(NormalPersonAdapter));
            container.RegisterType(typeof(IAdapter<IEnumerable<ICustomer>, IEnumerable<IPerson>>), typeof(NormalPersonEnumerableAdapter));
            container.RegisterType(typeof(IDesignPatternExample), typeof(PersonAdapterExample),
                "PersonAdapterExample");
            container.RegisterType(typeof(IDesignPatternExample), typeof(PersonEnumerableAdapterExample),
                "PersonEnumerableAdapterExample");

            // Customer Adapter Examples
            container.RegisterType(typeof(IAdapter<IPerson, ICustomer>), typeof(CustomerAdapter));
            container.RegisterType(typeof(IAdapter<IEnumerable<IPerson>, IEnumerable<ICustomer>>), typeof(CustomerEnumerableAdapter));
            container.RegisterType(typeof(IDesignPatternExample), typeof(CustomerAdapterExample),
                "CustomerAdapterExample");
            container.RegisterType(typeof(IDesignPatternExample), typeof(CustomerEnumerableAdapterExample),
                "CustomerEnumerableAdapterExample");

            // Behavior Example Setup
            container.RegisterType(typeof(IBehavior<IPerson>), typeof(PersonDisplayIdleBehavior),
                "PersonDisplayIdleBehavior");
            container.RegisterType(typeof(IBehavior<IPerson>), typeof(PersonDisplayStillBehavior),
                "PersonDisplayStillBehavior");
            container.RegisterType(typeof(IBehavior<IPerson>), typeof(PersonDisplayWalkBehavior),
                "PersonDisplayWalkBehavior");
            container.RegisterType(typeof(IBehavior<IPerson>), typeof(PersonDisplayRunBehavior),
                "PersonDisplayRunBehavior");
            container.RegisterType(typeof(IBehavior<IPerson>), typeof(PersonDisplayDriveBehavior),
                "PersonDisplayDriveBehavior");

            var displayIdleBehavior = container.Resolve<PersonDisplayIdleBehavior>("PersonDisplayIdleBehavior");
            var displayStillBehavior = container.Resolve<PersonDisplayStillBehavior>("PersonDisplayStillBehavior");
            var displayWalkBehavior = container.Resolve<PersonDisplayWalkBehavior>("PersonDisplayWalkBehavior");
            var displayRunBehavior = container.Resolve<PersonDisplayRunBehavior>("PersonDisplayRunBehavior");
            var displayDriveBehavior = container.Resolve<PersonDisplayDriveBehavior>("PersonDisplayDriveBehavior");

            // Normal Person Behavior Example
            var normalPersonAdapter = new NormalPersonAdapter();
            var normalPerson = normalPersonAdapter.Adapt(MockData.Customers[0]);
            normalPerson.DisplayIdleBehavior = displayIdleBehavior;
            normalPerson.DisplayStillBehavior = displayStillBehavior;
            normalPerson.DisplayWalkBehavior = displayWalkBehavior;
            normalPerson.DisplayRunBehavior = displayRunBehavior;
            normalPerson.DisplayDriveBehavior = displayDriveBehavior;
            container.RegisterType(typeof(IDesignPatternExample), typeof(PersonBehaviorExample),
                "NormalPersonBehaviorExample", new InjectionConstructor(
                    normalPerson));

            // Fast Person Behavior Example
            var fastPersonAdapter = new FastPersonAdapter();
            var fastPerson = fastPersonAdapter.Adapt(MockData.Customers[1]);
            fastPerson.DisplayIdleBehavior = displayIdleBehavior;
            fastPerson.DisplayStillBehavior = displayStillBehavior;
            fastPerson.DisplayWalkBehavior = displayWalkBehavior;
            fastPerson.DisplayRunBehavior = displayRunBehavior;
            fastPerson.DisplayDriveBehavior = displayDriveBehavior;
            container.RegisterType(typeof(IDesignPatternExample), typeof(PersonBehaviorExample),
                "FastPersonBehaviorExample", new InjectionConstructor(
                    fastPerson));
        }
    }
}
