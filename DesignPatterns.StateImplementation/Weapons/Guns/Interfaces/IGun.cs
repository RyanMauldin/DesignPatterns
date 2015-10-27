using System;
using DesignPatterns.Interfaces;
using DesignPatterns.StateImplementation.Ammunition.Containers.Interfaces;
using DesignPatterns.StateImplementation.Weapons.Interfaces;

namespace DesignPatterns.StateImplementation.Weapons.Guns.Interfaces
{
    /// <summary>
    /// Interface for gun classes.
    /// </summary>
    public interface IGun :
        IWeapon
    {
        /// <summary>
        /// Container to hold ammunition for the weapon. This
        /// can generally be a magazine or single fire cartrige.
        /// </summary>
        IAmmunitionContainer AmmunitionContainer { get; set; }

        /// <summary>
        /// Command for shoot attacks with weapon.
        /// </summary>
        ICommand ShootCommand { get; set; }

        /// <summary>
        /// Command for when attempting to shoot with empty weapon.
        /// </summary>
        ICommand EmptyGunFireCommand { get; set; }

        /// <summary>
        /// The date and time of the last shoot attack with the weapon.
        /// </summary>
        DateTime LastShot { get; set; }

        /// <summary>
        /// The rate of shoot attacks allowed with the weapon.
        /// </summary>
        decimal ShotRate { get; }

        /// <summary>
        /// The method to call to start a shoot attack with the weapon.
        /// </summary>
        void Shoot();

        /// <summary>
        /// The caliber of ammunition this weapon shoots.
        /// </summary>
        decimal Caliber { get; }

        /// <summary>
        /// The speed at which it takes to reload this weapon.
        /// </summary>
        decimal ReloadSpeed { get; }

        /// <summary>
        /// The base recoil force for this weapon. This should generally
        /// be multiplied with the ammunition type recoil force.
        /// </summary>
        decimal RecoilForce { get; }

        /// <summary>
        /// The method to call to reload the weapon.
        /// </summary>
        /// <param name="container">The ammunition container to pass in to fill the weopons magazine, etc.</param>
        /// <returns></returns>
        bool Reload(IAmmunitionContainer container);
    }
}
