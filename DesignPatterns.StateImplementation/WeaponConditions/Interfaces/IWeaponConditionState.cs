using DesignPatterns.StateImplementation.Interfaces;
using DesignPatterns.StateImplementation.Weapons.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions.Interfaces
{
    public interface IWeaponConditionState :
        IItem
    {
        IWeapon Weapon { get; }
        bool CanBePickedUp { get; }
        bool CanBeUsed { get; }
        decimal AccuracyMulitplier { get; }
        int UsesBeforeConditionStateChange { get; }
        int WeaponUses { get; }
        void WeaponUsed();
        void Reset();
    }
}
