namespace DesignPatterns.Interfaces
{
    /// <summary>
    /// Intent - Favoring composition of objects together,
    /// rather than inheritance can achieve big gains in the
    /// Object Oriented programming paradigm. Behaviors are
    /// really more of a classification in Design Pattern
    /// Lingo. The classification is "Behavioral" design
    /// patterns. However this is a nice interface to
    /// show how to achieve a family of alorithms or
    /// the Strategy Pattern.
    /// </summary>
    /// <typeparam name="T">The type to operate on.</typeparam>
    public interface IBehavior<in T>
        where T : class
    {
        /// <summary>
        /// The main behavioral method.
        /// </summary>
        /// <param name="target">The object of type T, as the target of behavior, if needed.</param>
        void Behave(T target);
    }
}
