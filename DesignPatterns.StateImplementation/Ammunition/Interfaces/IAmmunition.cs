using DesignPatterns.StateImplementation.Interfaces;

namespace DesignPatterns.StateImplementation.Ammunition.Interfaces
{
    public interface IAmmunition :
        IItem
    {
        decimal Caliber { get; }
        decimal AccuracyMulitplier { get; }
        decimal DamageMultiplier { get; }
        decimal BaseVelocity { get; }
        decimal ImpactForce { get; }
        decimal ImpactRadius { get; }
        decimal LifetimeTillImpact { get; }
        decimal RecoilForce { get; }
        bool IsArmorPiercing { get; }
    }
}
