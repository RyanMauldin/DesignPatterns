using System;
using DesignPatterns.Interfaces;
using DesignPatterns.StateImplementation.Ammunition.Containers.Interfaces;
using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;
using DesignPatterns.StateImplementation.Weapons.Guns.Interfaces;

namespace DesignPatterns.StateImplementation.Weapons.Guns
{
    public class M16 :
        Gun, IBurstFireGun
    {
        public M16(
            IWeaponConditionState perfectWeaponCondition,
            IWeaponConditionState usedWeaponCondition,
            IWeaponConditionState wornWeaponCondition,
            IWeaponConditionState damagedWeaponCondition,
            IWeaponConditionState destroyedWeaponCondition,
            IWeaponConditionState weaponCondition,
            ICommand meleeCommand,
            ICommand shootCommand,
            ICommand emptyGunFireCommand,
            IAmmunitionContainer ammunitionContainer,
            bool isBurstFireEngaged) :
                base(
                    perfectWeaponCondition,
                    usedWeaponCondition,
                    wornWeaponCondition,
                    damagedWeaponCondition,
                    destroyedWeaponCondition,
                    weaponCondition,
                    meleeCommand,
                    shootCommand,
                    emptyGunFireCommand,
                    ammunitionContainer)
        {
            IsBurstFireEngaged = isBurstFireEngaged;
        }

        // IItem
        public override string Name
        {
            get { return "M16"; }
        }

        public override string Description
        {
            get { return "The M16 is a semi-automatic rifle with a 3 round burst."; }
        }

        public override decimal Weight
        {
            get { return 7.18m; }
        }

        // IWeapon
        public override decimal ShotRate
        {
            get { return .25m; }
        }

        public override void Shoot()
        {
            lock (this)
            {
                if (LastShot.AddSeconds((double)ShotRate) < DateTime.UtcNow)
                    return;

                LastShot = DateTime.UtcNow;

                var bulletsForAttack = Math.Min(IsBurstFireEngaged ? 3 : 1, AmmunitionContainer.AmmunitionCount);
                AmmunitionContainer.AmmunitionCount -= bulletsForAttack;

                switch (bulletsForAttack)
                {
                    case 3:
                        // Command would create gun fire sound,
                        // bullets and sound, etc. These
                        // could be done asynchronously.
                        // Would prob be best to have M16 burst
                        // fire shoot commands vs. single fire, etc.
                        // for animation purposes instead of calling
                        // ShootCommand 3 times here.
                        ShootCommand.Execute();
                        WeaponCondition.WeaponUsed();
                        ShootCommand.Execute();
                        WeaponCondition.WeaponUsed();
                        ShootCommand.Execute();
                        WeaponCondition.WeaponUsed();
                        break;
                    case 2:
                        ShootCommand.Execute();
                        WeaponCondition.WeaponUsed();
                        ShootCommand.Execute();
                        WeaponCondition.WeaponUsed();
                        break;
                    case 1:
                        ShootCommand.Execute();
                        WeaponCondition.WeaponUsed();
                        break;
                    default:
                        EmptyGunFireCommand.Execute();
                        break;
                }
            }
        }

        public override decimal MeleeRate
        {
            get { return 1.25m; }
        }

        public override void Melee()
        {
            lock (this)
            {
                if (LastMelee.AddSeconds((double)MeleeRate) < DateTime.UtcNow)
                    return;

                LastMelee = DateTime.UtcNow;
                MeleeCommand.Execute();
                WeaponCondition.WeaponUsed();
            }
        }

        public override decimal AccuracyMulitplier
        {
            get { return WeaponCondition.AccuracyMulitplier; }
        }

        // IGun
        public override decimal Caliber
        {
            get { return AmmunitionContainer.Ammunition.Caliber; }
        }

        public override decimal ReloadSpeed
        {
            get { return 2; }
        }

        public override decimal RecoilForce
        {
            get { return AmmunitionContainer.Ammunition.RecoilForce; }
        }

        public override bool Reload(IAmmunitionContainer container)
        {
            lock (this)
            {
                if (!WeaponCondition.CanBeUsed)
                    return false;

                lock (container)
                {
                    var ammunitionCount = Math.Min(container.AmmunitionCount, AmmunitionContainer.MaxiumAmmunitionCount - AmmunitionContainer.AmmunitionCount);
                    if (ammunitionCount == 0)
                        return false; // No need to reload, already full, or container has no ammunition to give.

                    // In game engine, would play animation of trading out ammunition magazine or single bullet in bolt action rifle.
                    container.AmmunitionCount -= ammunitionCount;
                    AmmunitionContainer.AmmunitionCount += ammunitionCount;
                    return true;
                }
            }
        }

        // IBurstFireGun
        public int BurstCount
        {
            get { return 3; }
        }

        public bool IsBurstFireEngaged { get; set; }
    }
}
