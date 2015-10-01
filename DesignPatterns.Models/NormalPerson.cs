namespace DesignPatterns.Models
{
    /// <summary>
    /// Derived from Person, this class represents a Person
    /// who has a normal velocity multiplier for our examples.
    /// </summary>
    public class NormalPerson : Person
    {
        private const decimal DefaultVelocityMultiplier = 1m;

        public NormalPerson()
        {
            VelocityMultiplier = DefaultVelocityMultiplier;
        }
    }
}
