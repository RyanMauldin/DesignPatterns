using DesignPatterns.StateImplementation.Interfaces;

namespace DesignPatterns.StateImplementation.Ammunition.Interfaces
{
    /// <summary>
    /// Common interface for all ammunition. Many of the
    /// calculations could be changed per game engine and
    /// how physics are interpreted. Skills may also affect
    /// the calculations depending on how this is used.
    /// </summary>
    public interface IAmmunition :
        IItem
    {
        /// <summary>
        /// The caliber of bullet, bomb, or missle.
        /// </summary>
        decimal Caliber { get; }

        /// <summary>
        /// Accuracy multiplier for use in trajectory calculations.
        /// </summary>
        decimal AccuracyMulitplier { get; }

        /// <summary>
        /// Damage multiplier for use in damage calculations.
        /// </summary>
        decimal DamageMultiplier { get; }

        /// <summary>
        /// The base velocity of the ammunition. 
        /// </summary>
        decimal BaseVelocity { get; }

        /// <summary>
        /// The impact force of the ammuntion.
        /// </summary>
        decimal ImpactForce { get; }

        /// <summary>
        /// The radius of damage on ammunition impact.
        /// </summary>
        decimal ImpactRadius { get; }

        /// <summary>
        /// The lifetime of the ammunition.
        /// </summary>
        decimal LifetimeTillImpact { get; }

        /// <summary>
        /// The recoil force caused by using this ammunition.
        /// </summary>
        decimal RecoilForce { get; }

        /// <summary>
        /// Does this ammunition have armor piercing capabilities.
        /// </summary>
        bool IsArmorPiercing { get; }
    }
}
