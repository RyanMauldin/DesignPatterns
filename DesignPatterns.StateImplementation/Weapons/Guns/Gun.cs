using System;
using DesignPatterns.Interfaces;
using DesignPatterns.StateImplementation.Ammunition.Containers.Interfaces;
using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;
using DesignPatterns.StateImplementation.Weapons.Guns.Interfaces;

namespace DesignPatterns.StateImplementation.Weapons.Guns
{
    public abstract class Gun :
        Weapon, IGun
    {
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

        public IAmmunitionContainer AmmunitionContainer { get; set; }

        public ICommand ShootCommand { get; set; }
        public ICommand EmptyGunFireCommand { get; set; }

        public DateTime LastShot { get; set; }
        public abstract decimal ShotRate { get; }
        public abstract void Shoot();
        public abstract decimal Caliber { get; }
        public abstract decimal ReloadSpeed { get; }
        public abstract decimal RecoilForce { get; }
        public abstract bool Reload(IAmmunitionContainer container);
    }
}
