using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    /// <summary>
    /// Intent - Convert an initial class or interface, and adapt it into
    /// a result class or interface that a client expects.
    /// http://codereview.stackexchange.com/questions/51889/generic-converter-framework
    /// </summary>
    /// <typeparam name="TInput">The input type.</typeparam>
    /// <typeparam name="TOutput">The output type.</typeparam>
    public abstract class Converter<TInput, TOutput> :
        IConverter<TInput, TOutput>
        where TInput : class
        where TOutput : class
    {
        /// <summary>
        /// The main convert method.
        /// </summary>
        /// <param name="value">The input object to convert.</param>
        /// <returns>A converted value.</returns>
        public abstract TOutput Convert(TInput value);
    }
}
