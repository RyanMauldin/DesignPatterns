using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions
{
    /// <summary>
    /// Class for keeping up with Weapon Condition state.
    /// This is the State Context implementation.
    /// </summary>
    public class WeaponCondition :
        StateContext, IWeaponCondition
    {
        /// <summary>
        /// Specific Constructor
        /// </summary>
        /// <param name="perfectWeaponCondition">The Weapon Condition State for a perfect weapon that has almost no uses.</param>
        /// <param name="usedWeaponCondition">The Weapon Condition State for a weapon that has been used.</param>
        /// <param name="wornWeaponCondition">The Weapon Condition State for a weapon that has been used a while without repair.</param>
        /// <param name="damagedWeaponCondition">The Weapon Condition State for a weapon that has been used a lot and is damaged.</param>
        /// <param name="destroyedWeaponCondition">The Weapon Condition State for a weapon that has been destroyed and cannot be used.</param>
        /// <param name="currentWeaponCondition">The current Weapon Condition State of the weapon.</param>
        public WeaponCondition(
            IWeaponConditionState perfectWeaponCondition,
            IWeaponConditionState usedWeaponCondition,
            IWeaponConditionState wornWeaponCondition,
            IWeaponConditionState damagedWeaponCondition,
            IWeaponConditionState destroyedWeaponCondition,
            IWeaponConditionState currentWeaponCondition)
        {
            PerfectWeaponCondition = perfectWeaponCondition;
            PerfectWeaponCondition.StateContext = this;
            UsedWeaponCondition = usedWeaponCondition;
            UsedWeaponCondition.StateContext = this;
            WornWeaponCondition = wornWeaponCondition;
            WornWeaponCondition.StateContext = this;
            DamagedWeaponCondition = damagedWeaponCondition;
            DamagedWeaponCondition.StateContext = this;
            DestroyedWeaponCondition = destroyedWeaponCondition;
            DestroyedWeaponCondition.StateContext = this;
            CurrentState = currentWeaponCondition;
            CurrentState.StateContext = this;
            
        }

        #region IWeaponCondition

        /// <summary>
        /// The Weapon Condition State for a perfect weapon that has almost no uses.
        /// </summary>
        public IWeaponConditionState PerfectWeaponCondition { get; set; }

        /// <summary>
        /// The Weapon Condition State for a weapon that has been used.
        /// </summary>
        public IWeaponConditionState UsedWeaponCondition { get; set; }

        /// <summary>
        /// The Weapon Condition State for a weapon that has been used a while without repair.
        /// </summary>
        public IWeaponConditionState WornWeaponCondition { get; set; }

        /// <summary>
        /// The Weapon Condition State for a weapon that has been used a lot and is damaged.
        /// </summary>
        public IWeaponConditionState DamagedWeaponCondition { get; set; }

        /// <summary>
        /// The Weapon Condition State for a weapon that has been destroyed and cannot be used.
        /// </summary>
        public IWeaponConditionState DestroyedWeaponCondition { get; set; }

        #endregion
    }
}
