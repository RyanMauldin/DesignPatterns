using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions
{
    public abstract class WeaponConditionState :
        State, IWeaponConditionState
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract decimal Weight { get; }
        public abstract bool CanBePickedUp { get; }
        public abstract bool CanBeUsed { get; }
        public abstract decimal AccuracyMulitplier { get; }
        public abstract int UsesBeforeConditionStateChange { get; }
        public abstract int WeaponUses { get; }
        public abstract void WeaponUsed();
        public abstract void Reset();

        
    }
}
