using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    /// <summary>
    /// Intent - Favoring composition of objects together,
    /// rather than inheritance can achieve big gains in the
    /// Object Oriented programming paradigm. Behaviors are
    /// really more of a classification in Design Pattern
    /// lingo. The classification is "Behavioral" design
    /// patterns. However this is a nice interface to show
    /// how to achieve a family of alorithms or the Strategy
    /// Pattern. This is an example base class to derive from
    /// to give an example Behavior.
    /// </summary>
    /// <typeparam name="T">The type to operate on.</typeparam>
    public abstract class Behavior<T> :
        IBehavior<T>
        where T : class
    {
        /// <summary>
        /// The main behavioral method.
        /// </summary>
        /// <param name="target">The object of type T, as the target of behavior, if needed.</param>
        public abstract void Behave(T target);
    }
}
