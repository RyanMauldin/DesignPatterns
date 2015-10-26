using DesignPatterns.StateImplementation.WeaponConditions.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions
{
    public class WornWeaponConditionState :
        WeaponConditionState
    {
        private int _weaponUses;

        public WornWeaponConditionState()
        {
            
        }

        public WornWeaponConditionState(
            int weaponUses)
        {
            _weaponUses = weaponUses;
        }

        public override string Name
        {
            get { return "Worn"; }
        }

        public override string Description
        {
            get { return "This weapon is in a worn condition. It's accuracy will be affected and should be repaired."; }
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
            get { return .85m; }
        }

        public override int UsesBeforeConditionStateChange
        {
            get { return 70; }
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
            var nextState = ((IWeaponCondition)StateContext).DamagedWeaponCondition;
            nextState.Reset();
            StateContext.CurrentState = nextState;
        }

        public override void Reset()
        {
            _weaponUses = 0;
        }
    }
}
