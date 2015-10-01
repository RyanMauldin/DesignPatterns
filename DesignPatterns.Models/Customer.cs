using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.Models
{
    // Sample class for adapters and such.
    public class Customer : Person, ICustomer
    {
        public Customer()
        {
            VelocityMultiplier = 0.5m;
        }
        
        public string AccountNumber { get; set; }
        public string Company { get; set; }
    }
}
