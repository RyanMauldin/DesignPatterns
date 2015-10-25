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
            IWeaponConditionState perfectWeaponCondition,
            IWeaponConditionState usedWeaponCondition,
            IWeaponConditionState wornWeaponCondition,
            IWeaponConditionState damagedWeaponCondition,
            IWeaponConditionState destroyedWeaponCondition,
            IWeaponConditionState weaponCondition,
            ICommand meleeCommand)
        {
            PerfectWeaponCondition = perfectWeaponCondition;
            UsedWeaponCondition = usedWeaponCondition;
            WornWeaponCondition = wornWeaponCondition;
            DamagedWeaponCondition = damagedWeaponCondition;
            DestroyedWeaponCondition = destroyedWeaponCondition;
            WeaponCondition = weaponCondition;
            MeleeCommand = meleeCommand;
            LastMelee = DateTime.MinValue;
        }

        // IItem
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract decimal Weight { get; }

        // IWeapon
        public IWeaponConditionState PerfectWeaponCondition { get; set; }
        public IWeaponConditionState UsedWeaponCondition { get; set; }
        public IWeaponConditionState WornWeaponCondition { get; set; }
        public IWeaponConditionState DamagedWeaponCondition { get; set; }
        public IWeaponConditionState DestroyedWeaponCondition { get; set; }

        public IWeaponConditionState WeaponCondition { get; set; }

        public ICommand MeleeCommand { get; set; }

        public DateTime LastMelee { get; set; }
        public abstract decimal MeleeRate { get; }
        public abstract void Melee();
        public abstract decimal AccuracyMulitplier { get; }
    }
}
