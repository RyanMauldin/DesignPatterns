namespace DesignPatterns.Interfaces
{
    /// <summary>
    /// Intent - Convert an initial class or interface, and adapt it into
    /// a result class or interface that a client expects.
    /// http://codereview.stackexchange.com/questions/51889/generic-converter-framework
    /// </summary>
    /// <typeparam name="TInput">The input type.</typeparam>
    /// <typeparam name="TOutput">The Output type.</typeparam>
    public interface IConverter<in TInput, out TOutput>
        where TInput : class
        where TOutput : class
    {
        /// <summary>
        /// The main convert method.
        /// </summary>
        /// <param name="value">The input object to convert.</param>
        /// <returns>A converted value.</returns>
        TOutput Convert(TInput value);
    }
}