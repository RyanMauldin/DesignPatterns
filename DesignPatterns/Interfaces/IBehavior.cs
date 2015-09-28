using System.Text;

namespace DesignPatterns.Interfaces
{
    public interface IBehavior<in T>
        where T : class
    {
        void Behave(T target);
        void BehaveDebug(T target, StringBuilder builder);
    }
}
