using DesignPatterns.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions.Interfaces
{
    public interface IWeaponCondition :
        IStateContext
    {
        IWeaponConditionState PerfectWeaponCondition { get; set; }
        IWeaponConditionState UsedWeaponCondition { get; set; }
        IWeaponConditionState WornWeaponCondition { get; set; }
        IWeaponConditionState DamagedWeaponCondition { get; set; }
        IWeaponConditionState DestroyedWeaponCondition { get; set; }
    }
}
