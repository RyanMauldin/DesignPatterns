using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    /// <summary>
    /// Intent - Convert an initial interface, and adapt it into
    /// a result interface that a client expects. This is an example
    /// base class to derive from to give an example Adapter.
    /// </summary>
    /// <typeparam name="TInput">The input type.</typeparam>
    /// <typeparam name="TOutput">The Output type.</typeparam>
    public abstract class Adapter<TInput, TOutput> :
        IAdapter<TInput, TOutput>
        where TInput : class
        where TOutput : class
    {
        /// <summary>
        /// The main adaption method.
        /// </summary>
        /// <param name="value">The input object to adapt.</param>
        /// <returns>An adapted value.</returns>
        public abstract TOutput Adapt(TInput value);
    }
}
