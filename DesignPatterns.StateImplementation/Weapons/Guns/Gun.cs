using System;
using DesignPatterns.Interfaces;
using DesignPatterns.StateImplementation.Ammunition.Containers.Interfaces;
using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;
using DesignPatterns.StateImplementation.Weapons.Guns.Interfaces;

namespace DesignPatterns.StateImplementation.Weapons.Guns
{
    /// <summary>
    /// Abstract class for gun classes.
    /// </summary>
    public abstract class Gun :
        Weapon, IGun
    {
        /// <summary>
        /// Specific Constructor
        /// </summary>
        /// <param name="weaponCondition">The condition of the weapon.</param>
        /// <param name="meleeCommand">Command for melee attacks with weapon.</param>
        /// <param name="shootCommand">The rate of shoot attacks allowed with the weapon.</param>
        /// <param name="emptyGunFireCommand">Command for when attempting to shoot with empty weapon.</param>
        /// <param name="ammunitionContainer">Container to hold ammunition for the weapon.</param>
        protected Gun(
            IWeaponCondition weaponCondition,
            ICommand meleeCommand,
            ICommand shootCommand,
            ICommand emptyGunFireCommand,
            IAmmunitionContainer ammunitionContainer) :
                base(
                    weaponCondition,
                    meleeCommand)
        {
            ShootCommand = shootCommand;
            EmptyGunFireCommand = emptyGunFireCommand;
            AmmunitionContainer = ammunitionContainer;
            LastShot = DateTime.MinValue;
        }

        #region IGun

        /// <summary>
        /// Container to hold ammunition for the weapon. This
        /// can generally be a magazine or single fire cartrige.
        /// </summary>
        public IAmmunitionContainer AmmunitionContainer { get; set; }

        /// <summary>
        /// Command for shoot attacks with weapon.
        /// </summary>
        public ICommand ShootCommand { get; set; }

        /// <summary>
        /// Command for when attempting to shoot with empty weapon.
        /// </summary>
        public ICommand EmptyGunFireCommand { get; set; }

        /// <summary>
        /// The date and time of the last shoot attack with the weapon.
        /// </summary>
        public DateTime LastShot { get; set; }

        /// <summary>
        /// The rate of shoot attacks allowed with the weapon.
        /// </summary>
        public abstract decimal ShotRate { get; }

        /// <summary>
        /// The method to call to start a shoot attack with the weapon.
        /// </summary>
        public abstract void Shoot();

        /// <summary>
        /// The caliber of ammunition this weapon shoots.
        /// </summary>
        public abstract decimal Caliber { get; }

        /// <summary>
        /// The speed at which it takes to reload this weapon.
        /// </summary>
        public abstract decimal ReloadSpeed { get; }

        /// <summary>
        /// The base recoil force for this weapon. This should generally
        /// be multiplied with the ammunition type recoil force.
        /// </summary>
        public abstract decimal RecoilForce { get; }

        /// <summary>
        /// The method to call to reload the weapon.
        /// </summary>
        /// <param name="container">The ammunition container to pass in to fill the weopons magazine, etc.</param>
        /// <returns></returns>
        public abstract bool Reload(IAmmunitionContainer container);

        #endregion
    }
}
