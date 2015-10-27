using System;
using DesignPatterns.Interfaces;
using DesignPatterns.StateImplementation.Ammunition.Containers.Interfaces;
using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;
using DesignPatterns.StateImplementation.Weapons.Guns.Interfaces;

namespace DesignPatterns.StateImplementation.Weapons.Guns
{
    /// <summary>
    /// Class for an M16 semi-automatic rifle with a 3 round burst.
    /// </summary>
    public class M16 :
        Gun, IBurstFireGun
    {
        /// <summary>
        /// Specific Constructor
        /// </summary>
        /// <param name="weaponCondition">The condition of the weapon.</param>
        /// <param name="meleeCommand">Command for melee attacks with weapon.</param>
        /// <param name="shootCommand">The rate of shoot attacks allowed with the weapon.</param>
        /// <param name="emptyGunFireCommand">Command for when attempting to shoot with empty weapon.</param>
        /// <param name="ammunitionContainer">Container to hold ammunition for the weapon.</param>
        /// <param name="isBurstFireEngaged">If burst fire is currently engaged on the weapon.</param>
        public M16(
            IWeaponCondition weaponCondition,
            ICommand meleeCommand,
            ICommand shootCommand,
            ICommand emptyGunFireCommand,
            IAmmunitionContainer ammunitionContainer,
            bool isBurstFireEngaged) :
                base(
                    weaponCondition,
                    meleeCommand,
                    shootCommand,
                    emptyGunFireCommand,
                    ammunitionContainer)
        {
            IsBurstFireEngaged = isBurstFireEngaged;
        }


        #region IItem

        /// <summary>
        /// The common name of an item.
        /// </summary>
        public override string Name
        {
            get { return "M16"; }
        }

        /// <summary>
        /// The description of an item.
        /// </summary>
        public override string Description
        {
            get { return "The M16 is a semi-automatic rifle with a 3 round burst."; }
        }

        /// <summary>
        /// The weight of an item. Some items may not weigh anything.
        /// </summary>
        public override decimal Weight
        {
            get { return 7.18m; }
        }

        #endregion

        #region IGun

        /// <summary>
        /// The rate of shoot attacks allowed with the weapon.
        /// </summary>
        public override decimal ShotRate
        {
            get { return .25m; }
        }

        /// <summary>
        /// The method to call to start a shoot attack with the weapon.
        /// </summary>
        public override void Shoot()
        {
            lock (this)
            {
                if (!CurrentWeaponConditionState.CanBeUsed
                    || LastShot.AddSeconds((double)ShotRate) >= DateTime.UtcNow)
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
                        CurrentWeaponConditionState.WeaponUsed();
                        ShootCommand.Execute();
                        CurrentWeaponConditionState.WeaponUsed();
                        ShootCommand.Execute();
                        CurrentWeaponConditionState.WeaponUsed();
                        break;
                    case 2:
                        ShootCommand.Execute();
                        CurrentWeaponConditionState.WeaponUsed();
                        ShootCommand.Execute();
                        CurrentWeaponConditionState.WeaponUsed();
                        break;
                    case 1:
                        ShootCommand.Execute();
                        CurrentWeaponConditionState.WeaponUsed();
                        break;
                    default:
                        EmptyGunFireCommand.Execute();
                        break;
                }
            }
        }

        /// <summary>
        /// The caliber of ammunition this weapon shoots.
        /// </summary>
        public override decimal Caliber
        {
            get { return AmmunitionContainer.Ammunition.Caliber; }
        }

        /// <summary>
        /// The speed at which it takes to reload this weapon.
        /// </summary>
        public override decimal ReloadSpeed
        {
            get { return 2; }
        }

        /// <summary>
        /// The base recoil force for this weapon. This should generally
        /// be multiplied with the ammunition type recoil force.
        /// </summary>
        public override decimal RecoilForce
        {
            get { return AmmunitionContainer.Ammunition.RecoilForce; }
        }

        /// <summary>
        /// The method to call to reload the weapon.
        /// </summary>
        /// <param name="container">The ammunition container to pass in to fill the weopons magazine, etc.</param>
        /// <returns></returns>
        public override bool Reload(IAmmunitionContainer container)
        {
            lock (this)
            {
                if (!CurrentWeaponConditionState.CanBeUsed)
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

        #endregion

        #region IBurstFireGun

        /// <summary>
        /// The amount of shots that occur with a trigger pull.
        /// </summary>
        public int BurstCount
        {
            get { return 3; }
        }

        /// <summary>
        /// Is the burst fire mechanism engaged on the weapon.
        /// </summary>
        public bool IsBurstFireEngaged { get; set; }

        #endregion

        #region IWeapon

        /// <summary>
        /// The rate of melee attacks allowed with the weapon.
        /// </summary>
        public override decimal MeleeRate
        {
            get { return 1.25m; }
        }

        /// <summary>
        /// The method to call to start a melee atack with the weapon.
        /// </summary>
        public override void Melee()
        {
            lock (this)
            {
                if (!CurrentWeaponConditionState.CanBeUsed
                    || LastMelee.AddSeconds((double)MeleeRate) >= DateTime.UtcNow)
                    return;

                LastMelee = DateTime.UtcNow;
                MeleeCommand.Execute();
                CurrentWeaponConditionState.WeaponUsed();
            }
        }

        /// <summary>
        /// The accuracy mulitplier to use for the weapon.
        /// </summary>
        public override decimal AccuracyMulitplier
        {
            get { return CurrentWeaponConditionState.AccuracyMulitplier; }
        }

        #endregion

        /// <summary>
        /// Ease of access for current Weapon Condition State
        /// </summary>
        private IWeaponConditionState CurrentWeaponConditionState
        {
            get { return ((IWeaponConditionState)WeaponCondition.CurrentState); }
        }
    }
}
