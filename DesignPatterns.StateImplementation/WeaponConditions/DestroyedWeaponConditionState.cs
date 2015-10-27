namespace DesignPatterns.StateImplementation.WeaponConditions
{
    /// <summary>
    /// The Weapon Condition State for a weapon that has been destroyed and cannot be used.
    /// </summary>
    public class DestroyedWeaponConditionState :
        WeaponConditionState
    {
        /// <summary>
        /// Number of Weapon Uses for this state.
        /// </summary>
        private int _weaponUses;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public DestroyedWeaponConditionState()
        {
            
        }

        /// <summary>
        /// Specific Constructor.
        /// </summary>
        /// <param name="weaponUses">Number of weapon uses to start with.</param>
        public DestroyedWeaponConditionState(
            int weaponUses)
        {
            _weaponUses = weaponUses;
        }

        #region IItem

        /// <summary>
        /// The common name of an item.
        /// </summary>
        public override string Name
        {
            get { return "Destroyed"; }
        }

        /// <summary>
        /// The description of an item.
        /// </summary>
        public override string Description
        {
            get { return "This weapon is completely destroyed. It cannot be used or picked up."; }
        }

        /// <summary>
        /// The weight of an item. Some items may not weigh anything.
        /// </summary>
        public override decimal Weight
        {
            get { return 0; }
        }

        #endregion

        #region IWeaponConditionState

        /// <summary>
        /// Can the weapon be picked up.
        /// </summary>
        public override bool CanBePickedUp
        {
            get { return false; }
        }

        /// <summary>
        /// Can the weapon be used.
        /// </summary>
        public override bool CanBeUsed
        {
            get { return false; }
        }

        /// <summary>
        /// The accuracy multiplier for the weapon in this state.
        /// </summary>
        public override decimal AccuracyMulitplier
        {
            get { return 0m; }
        }

        /// <summary>
        /// The number of uses before the weapon condition state changes.
        /// </summary>
        public override int UsesBeforeConditionStateChange
        {
            get { return 0; }
        }

        /// <summary>
        /// The number of times the weapon has been used in this state.
        /// </summary>
        public override int WeaponUses
        {
            get { return _weaponUses; }
        }

        /// <summary>
        /// The method to call when the weapon gets used.
        /// </summary>
        public override void WeaponUsed()
        {
            // No-Op
        }

        /// <summary>
        /// Method to reset the state of this condition.
        /// This will set the WeaponUses variable to 0.
        /// </summary>
        public override void Reset()
        {
            _weaponUses = 0;
        }

        #endregion
    }
}
