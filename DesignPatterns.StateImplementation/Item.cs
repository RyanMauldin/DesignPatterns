using DesignPatterns.StateImplementation.Interfaces;

namespace DesignPatterns.StateImplementation
{
    public abstract class Item :
        IItem
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract decimal Weight { get; }
    }
}
