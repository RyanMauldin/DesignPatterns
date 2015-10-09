using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    /// <summary>
    /// Intent - Factory methods allow the user to create and
    /// initialize objects by delegating the work to a facotry
    /// method. The Factory Method pattern, when paired with IOC
    /// (Inversion of Control) pattern, is extremely powerful
    /// for Unit Tests, where Moch data objects need to be used
    /// instead of the real deal.
    /// </summary>
    /// <typeparam name="T">The Type of class to create.</typeparam>
    public abstract class FactoryMethod<T> :
        IFactoryMethod<T>
        where T : class, new()
    {
        /// <summary>
        /// The main factory method.
        /// </summary>
        /// <returns>A newed up instance of type T.</returns>
        public abstract T Create();
    }
}
