namespace DesignPatterns.Interfaces
{
    /// <summary>
    /// Intent - Convert an initial interface, and adapt it into
    /// a result interface that a client expects.
    /// </summary>
    /// <typeparam name="TInput">The input type.</typeparam>
    /// <typeparam name="TOutput">The Output type.</typeparam>
    public interface IAdapter<in TInput, out TOutput>
        where TInput : class
        where TOutput : class
    {
        /// <summary>
        /// The main adaption method.
        /// </summary>
        /// <param name="value">The input object to adapt.</param>
        /// <returns>An adapted value.</returns>
        TOutput Adapt(TInput value);
    }
}