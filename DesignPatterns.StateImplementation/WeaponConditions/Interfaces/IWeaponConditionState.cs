using DesignPatterns.Interfaces;
using DesignPatterns.StateImplementation.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions.Interfaces
{
    public interface IWeaponConditionState :
        IState, IItem
    {
        bool CanBePickedUp { get; }
        bool CanBeUsed { get; }
        decimal AccuracyMulitplier { get; }
        int UsesBeforeConditionStateChange { get; }
        int WeaponUses { get; }
        void WeaponUsed();
        void Reset();
    }
}
