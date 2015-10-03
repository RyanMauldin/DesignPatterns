using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    public abstract class FactoryMethodWithParameter<TInput, TOutput> :
        IFactoryMethodWithParameter<TInput, TOutput>
        where TInput : class
        where TOutput : class, new()
    {
        public virtual TOutput Create()
        {
            return new TOutput();
        }

        public abstract TOutput Create(TInput value);
    }
}
