using System;
using DesignPatterns.Interfaces;
using DesignPatterns.StateImplementation.Ammunition.Containers.Interfaces;
using DesignPatterns.StateImplementation.Weapons.Interfaces;

namespace DesignPatterns.StateImplementation.Weapons.Guns.Interfaces
{
    public interface IGun :
        IWeapon
    {
        IAmmunitionContainer AmmunitionContainer { get; set; }

       ICommand ShootCommand { get; set; }
       ICommand EmptyGunFireCommand { get; set; }

        DateTime LastShot { get; set; }
        decimal ShotRate { get; }
        void Shoot();
        decimal Caliber { get; }
        decimal ReloadSpeed { get; }
        decimal RecoilForce { get; }
        bool Reload(IAmmunitionContainer container);
    }
}
