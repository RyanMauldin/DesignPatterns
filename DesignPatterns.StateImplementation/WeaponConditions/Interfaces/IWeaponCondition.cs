using DesignPatterns.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions.Interfaces
{
    /// <summary>
    /// Interface for keeping up with Weapon Condition.
    /// This is the State Context implementation.
    /// </summary>
    public interface IWeaponCondition :
        IStateContext
    {
        /// <summary>
        /// The Weapon Condition State for a perfect weapon that has almost no uses.
        /// </summary>
        IWeaponConditionState PerfectWeaponCondition { get; set; }

        /// <summary>
        /// The Weapon Condition State for a weapon that has been used.
        /// </summary>
        IWeaponConditionState UsedWeaponCondition { get; set; }

        /// <summary>
        /// The Weapon Condition State for a weapon that has been used a while without repair.
        /// </summary>
        IWeaponConditionState WornWeaponCondition { get; set; }

        /// <summary>
        /// The Weapon Condition State for a weapon that has been used a lot and is damaged.
        /// </summary>
        IWeaponConditionState DamagedWeaponCondition { get; set; }

        /// <summary>
        /// The Weapon Condition State for a weapon that has been destroyed and cannot be used.
        /// </summary>
        IWeaponConditionState DestroyedWeaponCondition { get; set; }
    }
}
