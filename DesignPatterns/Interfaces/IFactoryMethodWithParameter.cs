namespace DesignPatterns.Interfaces
{
    public interface IFactoryMethodWithParameter<in TInput, out TOutput> :
        IFactoryMethod<TOutput>
        where TInput : class
        where TOutput : class, new()
    {
        TOutput Create(TInput value);
    }
}
