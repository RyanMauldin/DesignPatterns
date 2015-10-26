using System;
using DesignPatterns.Interfaces;
using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;
using DesignPatterns.StateImplementation.Weapons.Interfaces;

namespace DesignPatterns.StateImplementation.Weapons
{
    public abstract class Weapon :
        IWeapon
    {
        protected Weapon(
            IWeaponCondition weaponCondition,
            ICommand meleeCommand)
        {
            
            WeaponCondition = weaponCondition;
            MeleeCommand = meleeCommand;
            LastMelee = DateTime.MinValue;
        }

        // IItem
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract decimal Weight { get; }

        // IWeapon
        public IWeaponCondition WeaponCondition { get; set; }

        public ICommand MeleeCommand { get; set; }

        public DateTime LastMelee { get; set; }
        public abstract decimal MeleeRate { get; }
        public abstract void Melee();
        public abstract decimal AccuracyMulitplier { get; }
    }
}
