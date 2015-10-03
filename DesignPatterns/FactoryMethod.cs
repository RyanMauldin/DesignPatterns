using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    public abstract class FactoryMethod<T> :
        IFactoryMethod<T>
        where T : class, new()
    {
        public abstract T Create();
    }
}
