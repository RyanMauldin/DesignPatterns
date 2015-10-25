using DesignPatterns.StateImplementation.Ammunition.Interfaces;

namespace DesignPatterns.StateImplementation.Ammunition
{
    public abstract class Ammunition :
        IAmmunition
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract decimal Weight { get; }
        public abstract decimal Caliber { get; }
        public abstract decimal AccuracyMulitplier { get; }
        public abstract decimal DamageMultiplier { get; }
        public abstract decimal BaseVelocity { get; }
        public abstract decimal ImpactForce { get; }
        public abstract decimal ImpactRadius { get; }
        public abstract decimal LifetimeTillImpact { get; }
        public abstract decimal RecoilForce { get; }
        public abstract bool IsArmorPiercing { get; }
    }
}
