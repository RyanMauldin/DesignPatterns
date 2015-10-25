namespace DesignPatterns.StateImplementation.Weapons.Guns.Interfaces
{
    public interface IBurstFireGun 
    {
        int BurstCount { get; }
        bool IsBurstFireEngaged { get; set; }
    }
}
