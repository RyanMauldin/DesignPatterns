using DesignPatterns.StateImplementation.Weapons.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions
{
    public class PerfectWeaponConditionState :
        WeaponConditionState
    {
        private readonly IWeapon _weapon;
        private int _weaponUses;

        public PerfectWeaponConditionState(
            IWeapon weapon,
            int weaponUses)
        {
            _weapon = weapon;
            _weaponUses = weaponUses;
        }

        public override IWeapon Weapon
        {
            get { return _weapon; }
        }

        public override string Name
        {
            get { return "Perfect"; }
        }

        public override string Description
        {
            get { return "This weapon is in perfect condition."; }
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
            get { return 1m; }
        }

        public override int UsesBeforeConditionStateChange
        {
            get { return 200; }
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
            Weapon.WeaponCondition = Weapon.UsedWeaponCondition;
            Weapon.WeaponCondition.Reset();
        }

        public override void Reset()
        {
            _weaponUses = 0;
        }
    }
}
