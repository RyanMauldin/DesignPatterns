using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    public abstract class Behavior<T> :
        IBehavior<T>
        where T : class
    {
        public abstract void Behave(T target);
    }
}
