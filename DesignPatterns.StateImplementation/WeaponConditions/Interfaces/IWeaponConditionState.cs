using DesignPatterns.Interfaces;
using DesignPatterns.StateImplementation.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions.Interfaces
{
    /// <summary>
    /// An interface for describing weapon condition state.
    /// </summary>
    public interface IWeaponConditionState :
        IState, IItem
    {
        /// <summary>
        /// Can the weapon be picked up.
        /// </summary>
        bool CanBePickedUp { get; }

        /// <summary>
        /// Can the weapon be used.
        /// </summary>
        bool CanBeUsed { get; }

        /// <summary>
        /// The accuracy multiplier for the weapon in this state.
        /// </summary>
        decimal AccuracyMulitplier { get; }

        /// <summary>
        /// The number of uses before the weapon condition state changes.
        /// </summary>
        int UsesBeforeConditionStateChange { get; }

        /// <summary>
        /// The number of times the weapon has been used in this state.
        /// </summary>
        int WeaponUses { get; }

        /// <summary>
        /// The method to call when the weapon gets used.
        /// </summary>
        void WeaponUsed();

        /// <summary>
        /// Method to reset the state of this condition.
        /// This will set the WeaponUses variable to 0.
        /// </summary>
        void Reset();
    }
}
