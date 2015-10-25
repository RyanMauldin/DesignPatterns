using DesignPatterns.StateImplementation.Ammunition.Interfaces;
using DesignPatterns.StateImplementation.Interfaces;

namespace DesignPatterns.StateImplementation.Ammunition.Containers.Interfaces
{
    public interface IAmmunitionContainer :
        IItem
    {
        int AmmunitionCount { get; set; }
        int MaxiumAmmunitionCount { get; set; }
        IAmmunition Ammunition { get; set; }
    }
}
