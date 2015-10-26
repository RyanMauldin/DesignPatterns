using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions
{
    public class UsedWeaponConditionState :
        WeaponConditionState
    {
        private int _weaponUses;

        public UsedWeaponConditionState()
        {
            
        }

        public UsedWeaponConditionState(
            int weaponUses)
        {
            _weaponUses = weaponUses;
        }

        public override string Name
        {
            get { return "Used"; }
        }

        public override string Description
        {
            get { return "This weapon is in used condition. It's accuracy will be affected slightly."; }
        }

        public override decimal Weight
        {
            get { return 0; }
        }

        public override bool CanBePickedUp
        {
            get { return true; }
        }

        public override bool CanBeUsed
        {
            get { return true; }
        }

        public override decimal AccuracyMulitplier
        {
            get { return .9m; }
        }

        public override int UsesBeforeConditionStateChange
        {
            get { return 100; }
        }

        public override int WeaponUses
        {
            get { return _weaponUses; }
        }

        public override void WeaponUsed()
        {
            _weaponUses++;
            if (_weaponUses < UsesBeforeConditionStateChange)
                return;

            Reset();
            var nextState = ((IWeaponCondition)StateContext).WornWeaponCondition;
            nextState.Reset();
            StateContext.CurrentState = nextState;
        }

        public override void Reset()
        {
            _weaponUses = 0;
        }
    }
}
