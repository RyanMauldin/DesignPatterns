using System;
using DesignPatterns.Interfaces;
using DesignPatterns.StateImplementation.Interfaces;
using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;

namespace DesignPatterns.StateImplementation.Weapons.Interfaces
{
    /// <summary>
    /// Interface for weapon classes.
    /// </summary>
    public interface IWeapon :
        IItem
    {
        /// <summary>
        /// The condition of the weapon.
        /// </summary>
        IWeaponCondition WeaponCondition { get; set; }

        /// <summary>
        /// Command for melee attacks with weapon.
        /// </summary>
        ICommand MeleeCommand { get; set; }

        /// <summary>
        /// The date and time of the last melee attack with the weapon.
        /// </summary>
        DateTime LastMelee { get; set; }

        /// <summary>
        /// The rate of melee attacks allowed with the weapon.
        /// </summary>
        decimal MeleeRate { get; }

        /// <summary>
        /// The method to call to start a melee atack with the weapon.
        /// http://halo.wikia.com/wiki/Melee
        /// </summary>
        void Melee();

        /// <summary>
        /// The accuracy mulitplier to use for the weapon.
        /// </summary>
        decimal AccuracyMulitplier { get; }
    }
}
