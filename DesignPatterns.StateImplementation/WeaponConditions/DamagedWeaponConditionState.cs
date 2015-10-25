using DesignPatterns.StateImplementation.Weapons.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions
{
    public class DamagedWeaponConditionState :
        WeaponConditionState
    {
        private readonly IWeapon _weapon;
        private int _weaponUses;

        public DamagedWeaponConditionState(
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
            Weapon.WeaponCondition = Weapon.DestroyedWeaponCondition;
            Weapon.WeaponCondition.Reset();
        }

        public override void Reset()
        {
            _weaponUses = 0;
        }
    }
}
