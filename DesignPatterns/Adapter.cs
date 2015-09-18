using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    // Intent - Convert an initial interface, and adapt
    // it into a result interface that a client expects.
    public abstract class Adapter<TInput, TOutput> :
        IAdapter<TInput, TOutput>
        where TInput : class
        where TOutput : class
    {
        public abstract TOutput Adapt(TInput value);
    }
}
