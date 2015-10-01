namespace DesignPatterns.Models
{
    public class FastPerson : Person
    {
        private const decimal DefaultVelocityMultiplier = 2m;

        public FastPerson()
        {
            VelocityMultiplier = DefaultVelocityMultiplier;
        }
    }
}
