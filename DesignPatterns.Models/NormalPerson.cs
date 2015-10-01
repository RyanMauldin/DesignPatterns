namespace DesignPatterns.Models
{
    public class NormalPerson : Person
    {
        private const decimal DefaultVelocityMultiplier = 1m;

        public NormalPerson()
        {
            VelocityMultiplier = DefaultVelocityMultiplier;
        }
    }
}
