using DesignPatterns.StateImplementation.Weapons.Interfaces;

namespace DesignPatterns.StateImplementation.WeaponConditions
{
    public class DestroyedWeaponConditionState :
        WeaponConditionState
    {
        private readonly IWeapon _weapon;
        private int _weaponUses;

        public DestroyedWeaponConditionState(
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
            get { return "Destroyed"; }
        }

        public override string Description
        {
            get { return "This weapon is completely destroyed. It cannot be used or picked up."; }
        }

        public override decimal Weight
        {
            get { return 0; }
        }

        public override bool CanBePickedUp
        {
            get { return false; }
        }

        public override bool CanBeUsed
        {
            get { return false; }
        }

        public override decimal AccuracyMulitplier
        {
            get { return 0m; }
        }

        public override int UsesBeforeConditionStateChange
        {
            get { return 0; }
        }

        public override int WeaponUses
        {
            get { return _weaponUses; }
        }

        public override void WeaponUsed()
        {
            // No-Op
        }

        public override void Reset()
        {
            _weaponUses = 0;
        }
    }
}
