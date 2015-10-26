using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions
{
    public class WeaponCondition :
        StateContext, IWeaponCondition
    {
        public WeaponCondition(
            IWeaponConditionState perfectWeaponCondition,
            IWeaponConditionState usedWeaponCondition,
            IWeaponConditionState wornWeaponCondition,
            IWeaponConditionState damagedWeaponCondition,
            IWeaponConditionState destroyedWeaponCondition,
            IWeaponConditionState currentWeaponCondition)
        {
            PerfectWeaponCondition = perfectWeaponCondition;
            PerfectWeaponCondition.StateContext = this;
            UsedWeaponCondition = usedWeaponCondition;
            UsedWeaponCondition.StateContext = this;
            WornWeaponCondition = wornWeaponCondition;
            WornWeaponCondition.StateContext = this;
            DamagedWeaponCondition = damagedWeaponCondition;
            DamagedWeaponCondition.StateContext = this;
            DestroyedWeaponCondition = destroyedWeaponCondition;
            DestroyedWeaponCondition.StateContext = this;
            CurrentState = currentWeaponCondition;
            CurrentState.StateContext = this;
            
        }

        public IWeaponConditionState PerfectWeaponCondition { get; set; }
        public IWeaponConditionState UsedWeaponCondition { get; set; }
        public IWeaponConditionState WornWeaponCondition { get; set; }
        public IWeaponConditionState DamagedWeaponCondition { get; set; }
        public IWeaponConditionState DestroyedWeaponCondition { get; set; }
    }
}
