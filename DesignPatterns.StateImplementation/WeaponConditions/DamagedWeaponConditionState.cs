using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions
{
    public class DamagedWeaponConditionState :
        WeaponConditionState
    {
        private int _weaponUses;

        public DamagedWeaponConditionState()
        {
            
        }

        public DamagedWeaponConditionState(
            int weaponUses)
        {
            _weaponUses = weaponUses;
        }

        public override string Name
        {
            get { return "Damaged"; }
        }

        public override string Description
        {
            get { return "This weapon is in a damaged condition. It's accuracy will be affected."; }
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
            get { return .7m; }
        }

        public override int UsesBeforeConditionStateChange
        {
            get { return 40; }
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
            var nextState = ((IWeaponCondition)StateContext).DestroyedWeaponCondition;
            nextState.Reset();
            StateContext.CurrentState = nextState;
        }

        public override void Reset()
        {
            _weaponUses = 0;
        }
    }
}
