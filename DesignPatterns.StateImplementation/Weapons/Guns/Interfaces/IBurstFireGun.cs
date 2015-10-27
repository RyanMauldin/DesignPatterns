namespace DesignPatterns.StateImplementation.Weapons.Guns.Interfaces
{
    /// <summary>
    /// Interface for burst fire guns. Burst fire guns
    /// can shoot multiple shots in a single trigger pull.
    /// </summary>
    public interface IBurstFireGun 
    {
        /// <summary>
        /// The amount of shots that occur with a trigger pull.
        /// </summary>
        int BurstCount { get; }

        /// <summary>
        /// Is the burst fire mechanism engaged on the weapon.
        /// </summary>
        bool IsBurstFireEngaged { get; set; }
    }
}
