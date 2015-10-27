using System;
using DesignPatterns.Interfaces;
using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;
using DesignPatterns.StateImplementation.Weapons.Interfaces;

namespace DesignPatterns.StateImplementation.Weapons
{
    /// <summary>
    /// Abstract class for weapon classes.
    /// </summary>
    public abstract class Weapon :
        IWeapon
    {
        /// <summary>
        /// Specific Constructor
        /// </summary>
        /// <param name="weaponCondition">The condition of the weapon.</param>
        /// <param name="meleeCommand">Command for melee attacks with weapon.</param>
        protected Weapon(
            IWeaponCondition weaponCondition,
            ICommand meleeCommand)
        {
            
            WeaponCondition = weaponCondition;
            MeleeCommand = meleeCommand;
            LastMelee = DateTime.MinValue;
        }

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

        #region IWeapon

        /// <summary>
        /// The condition of the weapon.
        /// </summary>
        public IWeaponCondition WeaponCondition { get; set; }

        /// <summary>
        /// Command for melee attacks with weapon.
        /// </summary>
        public ICommand MeleeCommand { get; set; }

        /// <summary>
        /// The date and time of the last melee attack with the weapon.
        /// </summary>
        public DateTime LastMelee { get; set; }

        /// <summary>
        /// The rate of melee attacks allowed with the weapon.
        /// </summary>
        public abstract decimal MeleeRate { get; }

        /// <summary>
        /// The method to call to start a melee atack with the weapon.
        /// </summary>
        public abstract void Melee();

        /// <summary>
        /// The accuracy mulitplier to use for the weapon.
        /// </summary>
        public abstract decimal AccuracyMulitplier { get; }

        #endregion
    }
}
