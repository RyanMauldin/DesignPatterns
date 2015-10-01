namespace DesignPatterns.Interfaces
{
    public interface IBehavior<in T>
        where T : class
    {
        void Behave(T target);
    }
}
