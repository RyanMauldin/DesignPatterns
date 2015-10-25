namespace DesignPatterns.StateImplementation.Ammunition
{
    /// <summary>
    /// https://en.wikipedia.org/wiki/M16_rifle#Range_and_accuracy
    /// https://en.wikipedia.org/wiki/5.56%C3%9745mm_NATO
    /// </summary>
    public class M16StandardAmmunition
        : Ammunition
    {
        public override string Name
        {
            get { return "M16 Ammunition"; }
        }

        public override string Description
        {
            get { return "This is standard M16 Ammunition."; }
        }

        public override decimal Weight
        {
            get { return 0.0088m; }
        }

        public override decimal Caliber
        {
            get { return 5.56m; }
        }

        public override decimal AccuracyMulitplier
        {
            get { return .95m; }
        }

        public override decimal DamageMultiplier
        {
            get { return 1.5m; } // Based on game scheme
        }

        public override decimal BaseVelocity
        {
            get { return 3250m; } // 3,250 fps (foot lbs per second) - will prob change for game engine
        }

        public override decimal ImpactForce
        {
            get { return 1302m; }  // 3,250 fps (foot lbs per second) - will prob change for game engine
        }

        public override decimal ImpactRadius
        {
            get { return .125m; } // Game Units - incorporate network lag
        }

        public override decimal LifetimeTillImpact
        {
            get { return 10m; } // Lifetime in seconds
        }

        public override decimal RecoilForce
        {
            get { return 5.1m; } // Light recoil - 5.1 fps (foot lbs per second) - will prob change for game engine
        }

        public override bool IsArmorPiercing
        {
            get { return true; }
        }
    }
}
