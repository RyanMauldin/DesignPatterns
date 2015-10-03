namespace DesignPatterns.Interfaces
{
    public interface IFactoryMethod<out T>
        where T : class, new()
    {
        T Create();
    }
}