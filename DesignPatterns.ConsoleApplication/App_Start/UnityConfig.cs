using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using DesignPatterns.AdapterImplementation;
using DesignPatterns.BehaviorImplementation;
using DesignPatterns.CommandImplementation;
using DesignPatterns.CommandImplementation.Interfaces;
using DesignPatterns.ConsoleApplication.Data;
using DesignPatterns.ConsoleApplication.DesignPatternExamples;
using DesignPatterns.ConsoleApplication.Interfaces;
using DesignPatterns.FactoryMethodImplementation;
using DesignPatterns.Interfaces;
using DesignPatterns.Models;
using DesignPatterns.Models.Interfaces;
using Microsoft.Practices.Unity;

namespace DesignPatterns.ConsoleApplication
{
    /// <summary>
    /// The Unity Container configuration class shows IOC (Inverson of Control)
    /// Design Pattern and principals.
    /// </summary>
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
            // StringBuilder to build example output initialized with decent memory buffer.
            var builder = new StringBuilder(8192);
            container.RegisterInstance("ExampleConsoleOutput", builder);

            // Person Adapter Examples
            container.RegisterType<IAdapter<ICustomer, IPerson>, NormalPersonAdapter>();
            container.RegisterType<
                IAdapter<IEnumerable<ICustomer>, IEnumerable<IPerson>>,
                NormalPersonEnumerableAdapter>();
            container.RegisterType<IDesignPatternExample,
                PersonAdapterExample>("PersonAdapterExample");
            container.RegisterType<IDesignPatternExample,
                PersonEnumerableAdapterExample>("PersonEnumerableAdapterExample");

            // Customer Adapter Examples
            container.RegisterType<IAdapter<IPerson, ICustomer>, CustomerAdapter>();
            container.RegisterType<
                IAdapter<IEnumerable<IPerson>, IEnumerable<ICustomer>>,
                CustomerEnumerableAdapter>();
            container.RegisterType<IDesignPatternExample,
                CustomerAdapterExample>("CustomerAdapterExample");
            container.RegisterType<IDesignPatternExample,
                CustomerEnumerableAdapterExample>("CustomerEnumerableAdapterExample");
            
            // Behavior Example Setup
            container.RegisterType<IBehavior<IPerson>,
                PersonDisplayIdleBehavior>(
                    "PersonDisplayIdleBehavior",
                    new InjectionConstructor(
                        new ResolvedParameter<StringBuilder>("ExampleConsoleOutput")));
            container.RegisterType<IBehavior<IPerson>,
                PersonDisplayStillBehavior>(
                    "PersonDisplayStillBehavior",
                    new InjectionConstructor(
                        new ResolvedParameter<StringBuilder>("ExampleConsoleOutput")));
            container.RegisterType<IBehavior<IPerson>,
                PersonDisplayWalkBehavior>(
                    "PersonDisplayWalkBehavior",
                    new InjectionConstructor(
                        new ResolvedParameter<StringBuilder>("ExampleConsoleOutput")));
            container.RegisterType<IBehavior<IPerson>,
                PersonDisplayRunBehavior>(
                    "PersonDisplayRunBehavior",
                    new InjectionConstructor(
                        new ResolvedParameter<StringBuilder>("ExampleConsoleOutput")));
            container.RegisterType<IBehavior<IPerson>,
                PersonDisplayDriveBehavior>(
                    "PersonDisplayDriveBehavior",
                    new InjectionConstructor(
                        new ResolvedParameter<StringBuilder>("ExampleConsoleOutput")));

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
            container.RegisterType<IDesignPatternExample,
                PersonBehaviorExample>(
                    "NormalPersonBehaviorExample",
                    new InjectionConstructor(normalPerson));

            // Fast Person Behavior Example
            var fastPersonAdapter = new FastPersonAdapter();
            var fastPerson = fastPersonAdapter.Adapt(MockData.Customers[1]);
            fastPerson.DisplayIdleBehavior = displayIdleBehavior;
            fastPerson.DisplayStillBehavior = displayStillBehavior;
            fastPerson.DisplayWalkBehavior = displayWalkBehavior;
            fastPerson.DisplayRunBehavior = displayRunBehavior;
            fastPerson.DisplayDriveBehavior = displayDriveBehavior;
            container.RegisterType<IDesignPatternExample,
                PersonBehaviorExample>(
                    "FastPersonBehaviorExample",
                    new InjectionConstructor(fastPerson));

            // Fast Person Factory Method Example.
            container.RegisterType<IFactoryMethod<FastPerson>, FastPersonFactoryMethod>();
            container.RegisterType<IDesignPatternExample,
                FastPersonFactoryMethodExample>(
                    "FastPersonFactoryMethodExample");

            // Fast Person Factory Method With Parameter Example.
            container.RegisterType<IFactoryMethodWithParameter<ICustomer, FastPerson>, FastPersonFactoryMethodWithParameter>();
            container.RegisterType<IDesignPatternExample,
                FastPersonFactoryMethodWithParameterExample>(
                    "FastPersonFactoryMethodWithParameterExample");

            // Normal Person Factory Method Example.
            container.RegisterType<IFactoryMethod<NormalPerson>, NormalPersonFactoryMethod>();
            container.RegisterType<IDesignPatternExample,
                NormalPersonFactoryMethodExample>(
                    "NormalPersonFactoryMethodExample");

            // Normal Person Factory Method With Parameter Example.
            container.RegisterType<IFactoryMethodWithParameter<ICustomer, NormalPerson>, NormalPersonFactoryMethodWithParameter>();
            container.RegisterType<IDesignPatternExample,
                NormalPersonFactoryMethodWithParameterExample>(
                    "NormalPersonFactoryMethodWithParameterExample");

            // Command Pattern Example
            var maximumCommandStackSize = Convert.ToInt32(ConfigurationManager.AppSettings["MaximumCommandStackSize"]);
            container.RegisterType<ICommandManager, CommandManager>(
                "CommandManager",
                new InjectionConstructor(maximumCommandStackSize));
            container.RegisterType<ICommand, SkipCommand>(
                "SkipCommand",
                new InjectionConstructor(
                    new ResolvedParameter<StringBuilder>("ExampleConsoleOutput")));
            container.RegisterType<ICommand, HitCommand>(
                "HitCommand",
                new InjectionConstructor(
                    new ResolvedParameter<StringBuilder>("ExampleConsoleOutput")));
            container.RegisterType<ICommand, ShootCommand>(
                "ShootCommand",
                new InjectionConstructor(
                    new ResolvedParameter<StringBuilder>("ExampleConsoleOutput")));
            container.RegisterType<IDesignPatternExample,
                CommandPatternExample>(
                    "CommandPatternExample",
                    new InjectionConstructor(
                        new ResolvedParameter<CommandManager>("CommandManager"),
                        new ResolvedParameter<ICommand>("SkipCommand"),
                        new ResolvedParameter<ICommand>("HitCommand"),
                        new ResolvedParameter<ICommand>("ShootCommand")));
        }
    }
}
