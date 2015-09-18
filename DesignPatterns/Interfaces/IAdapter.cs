namespace DesignPatterns.Interfaces
{
    public interface IAdapter<in TInput, out TOutput>
        where TInput : class
        where TOutput : class
    {
        TOutput Adapt(TInput value);
    }
}