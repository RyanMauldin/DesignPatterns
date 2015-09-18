using System.Text;

namespace DesignPatterns.ConsoleApplication.Interfaces
{
    public interface IDesignPatternExample
    {
        void GetHeader(StringBuilder builder);
        void Run(StringBuilder builder);
    }
}