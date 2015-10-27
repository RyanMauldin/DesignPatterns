using DesignPatterns.StateImplementation.Ammunition.Interfaces;

namespace DesignPatterns.StateImplementation.Ammunition
{
    /// <summary>
    /// Common base class for all ammunition. Many of the
    /// calculations could be changed per game engine and
    /// how physics are interpreted. Skills may also affect
    /// the calculations depending on how this is used.
    /// </summary>
    public abstract class Ammunition :
        IAmmunition
    {
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

        #region IAmmunition

        /// <summary>
        /// The caliber of bullet, bomb, or missle.
        /// </summary>
        public abstract decimal Caliber { get; }
        
        /// <summary>
        /// Accuracy multiplier for use in trajectory calculations.
        /// </summary>
        public abstract decimal AccuracyMulitplier { get; }

        /// <summary>
        /// Damage multiplier for use in damage calculations.
        /// </summary>
        public abstract decimal DamageMultiplier { get; }

        /// <summary>
        /// The base velocity of the ammunition. 
        /// </summary>
        public abstract decimal BaseVelocity { get; }

        /// <summary>
        /// The impact force of the ammuntion.
        /// </summary>
        public abstract decimal ImpactForce { get; }

        /// <summary>
        /// The radius of damage on ammunition impact.
        /// </summary>
        public abstract decimal ImpactRadius { get; }

        /// <summary>
        /// The lifetime of the ammunition.
        /// </summary>
        public abstract decimal LifetimeTillImpact { get; }

        /// <summary>
        /// The recoil force caused by using this ammunition.
        /// </summary>
        public abstract decimal RecoilForce { get; }

        /// <summary>
        /// Does this ammunition have armor piercing capabilities.
        /// </summary>
        public abstract bool IsArmorPiercing { get; }

        #endregion
    }
}
