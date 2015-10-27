namespace DesignPatterns.StateImplementation.Ammunition
{
    /// <summary>
    /// M16 Standard Ammunition class. This class could derive
    /// from a 5.56 caliber ammunition class and be purely
    /// used for when used with an M16. Many of the
    /// calculations could be changed per game engine and
    /// how physics are interpreted. Skills may also affect
    /// the calculations depending on how this is used.
    /// https://en.wikipedia.org/wiki/M16_rifle#Range_and_accuracy
    /// https://en.wikipedia.org/wiki/5.56%C3%9745mm_NATO
    /// </summary>
    public class M16StandardAmmunition
        : Ammunition
    {
        #region IItem

        /// <summary>
        /// The common name of an item.
        /// </summary>
        public override string Name
        {
            get { return "M16 Ammunition"; }
        }

        /// <summary>
        /// The description of an item.
        /// </summary>
        public override string Description
        {
            get { return "This is standard M16 Ammunition."; }
        }

        /// <summary>
        /// The weight of an item. Some items may not weigh anything.
        /// </summary>
        public override decimal Weight
        {
            get { return 0.0088m; }
        }

        #endregion

        #region IAmmunition

        /// <summary>
        /// The caliber of bullet, bomb, or missle.
        /// </summary>
        public override decimal Caliber
        {
            get { return 5.56m; }
        }

        /// <summary>
        /// Accuracy multiplier for use in trajectory calculations.
        /// </summary>
        public override decimal AccuracyMulitplier
        {
            get { return .95m; }
        }

        /// <summary>
        /// Damage multiplier for use in damage calculations.
        /// </summary>
        public override decimal DamageMultiplier
        {
            get { return 1.5m; } // Based on game scheme
        }

        /// <summary>
        /// The base velocity of the ammunition. 
        /// </summary>
        public override decimal BaseVelocity
        {
            get { return 3250m; } // 3,250 fps (foot lbs per second) - will prob change for game engine
        }

        /// <summary>
        /// The impact force of the ammuntion.
        /// </summary>
        public override decimal ImpactForce
        {
            get { return 1302m; }  // 3,250 fps (foot lbs per second) - will prob change for game engine
        }

        /// <summary>
        /// The radius of damage on ammunition impact.
        /// </summary>
        public override decimal ImpactRadius
        {
            get { return .125m; } // Game Units - incorporate network lag
        }

        /// <summary>
        /// The lifetime of the ammunition.
        /// </summary>
        public override decimal LifetimeTillImpact
        {
            get { return 10m; } // Lifetime in seconds
        }

        /// <summary>
        /// The recoil force caused by using this ammunition.
        /// </summary>
        public override decimal RecoilForce
        {
            get { return 5.1m; } // Light recoil - 5.1 fps (foot lbs per second) - will prob change for game engine
        }

        /// <summary>
        /// Does this ammunition have armor piercing capabilities.
        /// </summary>
        public override bool IsArmorPiercing
        {
            get { return true; }
        }

        #endregion
    }
}
