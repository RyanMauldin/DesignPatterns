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
using DesignPatterns.StateImplementation.Ammunition;
using DesignPatterns.StateImplementation.Ammunition.Containers;
using DesignPatterns.StateImplementation.Ammunition.Containers.Interfaces;
using DesignPatterns.StateImplementation.Ammunition.Interfaces;
using DesignPatterns.StateImplementation.WeaponConditions;
using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;
using DesignPatterns.StateImplementation.Weapons.Guns;
using DesignPatterns.StateImplementation.Weapons.Guns.Interfaces;
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
            container.RegisterType<ICommand, MeleeCommand>(
                "MeleeCommand",
                new InjectionConstructor(
                    new ResolvedParameter<StringBuilder>("ExampleConsoleOutput")));
            container.RegisterType<ICommand, EmptyGunFireCommand>(
                "EmptyGunFireCommand",
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

            // State Pattern Example
            container.RegisterType<IWeaponConditionState, PerfectWeaponConditionState>(
                "PerfectWeaponConditionState",
                new InjectionConstructor());
            container.RegisterType<IWeaponConditionState, UsedWeaponConditionState>(
                "UsedWeaponConditionState",
                new InjectionConstructor());
            container.RegisterType<IWeaponConditionState, WornWeaponConditionState>(
                "WornWeaponConditionState",
                new InjectionConstructor());
            container.RegisterType<IWeaponConditionState, DamagedWeaponConditionState>(
                "DamagedWeaponConditionState",
                new InjectionConstructor());
            container.RegisterType<IWeaponConditionState, DestroyedWeaponConditionState>(
                "DestroyedWeaponConditionState",
                new InjectionConstructor());
            container.RegisterType<IWeaponCondition, WeaponCondition>(
                "WeaponCondition",
                new InjectionConstructor(
                    new ResolvedParameter<IWeaponConditionState>("PerfectWeaponConditionState"),
                    new ResolvedParameter<IWeaponConditionState>("UsedWeaponConditionState"),
                    new ResolvedParameter<IWeaponConditionState>("WornWeaponConditionState"),
                    new ResolvedParameter<IWeaponConditionState>("DamagedWeaponConditionState"),
                    new ResolvedParameter<IWeaponConditionState>("DestroyedWeaponConditionState"),
                    new ResolvedParameter<IWeaponConditionState>("PerfectWeaponConditionState")));
            const int m16StandardAmmunitionMagazineSize = 20;
            const int m16StandardAmmunitionBoxSize = 200;
            container.RegisterType<IAmmunition, M16StandardAmmunition>(
                "M16StandardAmmunition");
            container.RegisterType<IAmmunitionContainer, AmmunitionMagazine>(
                "M16StandardAmmunitionMagazine",
                new InjectionConstructor(
                    new ResolvedParameter<IAmmunition>("M16StandardAmmunition"),
                    m16StandardAmmunitionMagazineSize,
                    m16StandardAmmunitionMagazineSize));
            container.RegisterType<IAmmunitionContainer, AmmunitionMagazine>(
                "M16StandardAmmunitionBox",
                new InjectionConstructor(
                    new ResolvedParameter<IAmmunition>("M16StandardAmmunition"),
                    m16StandardAmmunitionBoxSize,
                    m16StandardAmmunitionBoxSize));
            const bool isBurstFireEngaged = true;
            container.RegisterType<IGun, M16>(
                "M16",
                new InjectionConstructor(
                    new ResolvedParameter<IWeaponCondition>("WeaponCondition"),
                    new ResolvedParameter<ICommand>("MeleeCommand"),
                    new ResolvedParameter<ICommand>("ShootCommand"),
                    new ResolvedParameter<ICommand>("EmptyGunFireCommand"),
                    new ResolvedParameter<IAmmunitionContainer>("M16StandardAmmunitionMagazine"),
                    isBurstFireEngaged));
            container.RegisterType<IDesignPatternExample,
                StatePatternExample>(
                    "StatePatternExample",
                    new InjectionConstructor(
                        new ResolvedParameter<IGun>("M16"),
                        new ResolvedParameter<IAmmunitionContainer>("M16StandardAmmunitionBox")));
        }
    }
}
