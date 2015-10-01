namespace DesignPatterns.Models
{
    /// <summary>
    /// Derived from Person, this class represents a Person
    /// who has a fast velocity multiplier for our examples.
    /// </summary>
    public class FastPerson : Person
    {
        private const decimal DefaultVelocityMultiplier = 2m;

        public FastPerson()
        {
            VelocityMultiplier = DefaultVelocityMultiplier;
        }
    }
}
