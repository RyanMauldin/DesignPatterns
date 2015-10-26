using System.Text;
using System.Threading;
using DesignPatterns.StateImplementation.Ammunition.Containers.Interfaces;
using DesignPatterns.StateImplementation.Weapons.Guns.Interfaces;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    /// <summary>
    /// The State Pattern Example
    /// </summary>
    public class StatePatternExample :
        DesignPatternExample
    {
        private readonly IGun _gun;
        private readonly IAmmunitionContainer _ammunitionContainer;

        public StatePatternExample(
            IGun gun,
            IAmmunitionContainer ammunitionContainer)
        {
            _gun = gun;
            _ammunitionContainer = ammunitionContainer;
        }

        /// <summary>
        /// The run method, runs your example design pattern
        /// and gathers output for the Console in the
        /// passed in StringBuilder.
        /// </summary>
        /// <param name="builder">The StringBuilder to gather output for the Console.</param>
        public override void Run(StringBuilder builder)
        {
            base.Run(builder);
            lock (builder)
            {
                var meleeRate = ((int)(_gun.MeleeRate * 1000));
                var shotRate = ((int)(_gun.ShotRate * 1000));
                _gun.Melee();
                Thread.Sleep(meleeRate);
                _gun.Shoot();
                Thread.Sleep(shotRate);
                _gun.Shoot();
                Thread.Sleep(shotRate);
                _gun.Shoot();
                Thread.Sleep(shotRate);
                _gun.Melee();
                Thread.Sleep(meleeRate);
                var gun = _gun as IBurstFireGun;
                if (gun != null)
                    gun.IsBurstFireEngaged = false;
                _gun.Shoot();
                Thread.Sleep(shotRate);
                _gun.Shoot();
                _gun.Reload(_ammunitionContainer);
            }
        }
    }
}
