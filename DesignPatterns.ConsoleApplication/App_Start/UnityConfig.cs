using System;
using System.Collections.Generic;
using DesignPatterns.AdapterImplementation;
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
            container.RegisterType(typeof(IAdapter<ICustomer, IPerson>), typeof(PersonAdapter));
            container.RegisterType(typeof(IAdapter<IEnumerable<ICustomer>, IEnumerable<IPerson>>), typeof(PersonEnumerableAdapter));
            container.RegisterType(typeof(IDesignPatternExample), typeof(PersonAdapterExample),
                "PersonAdapterExample");
            container.RegisterType(typeof(IDesignPatternExample), typeof(PersonEnumerableAdapterExample),
                "PersonEnumerableAdapterExample");
        }
    }
}
