using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions
{
    /// <summary>
    /// The base class for Weapon Condition States.
    /// </summary>
    public abstract class WeaponConditionState :
        State, IWeaponConditionState
    {
        #region IItem

        /// <summary>
        /// The common name of an item.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// The description of an item.
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// The weight of an item. Some items may not weigh anything.
        /// </summary>
        public abstract decimal Weight { get; }

        #endregion

        #region IWeaponConditionState

        /// <summary>
        /// Can the weapon be picked up.
        /// </summary>
        public abstract bool CanBePickedUp { get; }

        /// <summary>
        /// Can the weapon be used.
        /// </summary>
        public abstract bool CanBeUsed { get; }

        /// <summary>
        /// The accuracy multiplier for the weapon in this state.
        /// </summary>
        public abstract decimal AccuracyMulitplier { get; }

        /// <summary>
        /// The number of uses before the weapon condition state changes.
        /// </summary>
        public abstract int UsesBeforeConditionStateChange { get; }

        /// <summary>
        /// The number of times the weapon has been used in this state.
        /// </summary>
        public abstract int WeaponUses { get; }

        /// <summary>
        /// The method to call when the weapon gets used.
        /// </summary>
        public abstract void WeaponUsed();

        /// <summary>
        /// Method to reset the state of this condition.
        /// This will set the WeaponUses variable to 0.
        /// </summary>
        public abstract void Reset();

        #endregion
    }
}
