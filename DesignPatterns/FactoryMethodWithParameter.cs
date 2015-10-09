﻿using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    /// <summary>
    /// Intent - Factory methods allow the user to create and
    /// initialize objects by delegating the work to a facotry
    /// method. The Factory Method pattern, when paired with IOC
    /// (Inversion of Control) pattern, is extremely powerful
    /// for Unit Tests, where Moch data objects need to be used
    /// instead of the real deal. The class extends Factory
    /// Method offering an additional Create method which holds
    /// an Input value model.
    /// </summary>
    /// <typeparam name="TInput">A Type to pass in to the facotry method for more extensibility.</typeparam>
    /// <typeparam name="TOutput">The Type of class to create.</typeparam>
    public abstract class FactoryMethodWithParameter<TInput, TOutput> :
        IFactoryMethodWithParameter<TInput, TOutput>
        where TInput : class
        where TOutput : class, new()
    {
        /// <summary>
        /// The main factory method.
        /// </summary>
        /// <returns>A newed up instance of type T.</returns>
        public virtual TOutput Create()
        {
            return new TOutput();
        }

        /// <summary>
        /// The main factory method, with an Input parameter.
        /// </summary>
        /// <param name="value">The input parameter.</param>
        /// <returns>A newed up instance of type T.</returns>
        public abstract TOutput Create(TInput value);
    }
}
