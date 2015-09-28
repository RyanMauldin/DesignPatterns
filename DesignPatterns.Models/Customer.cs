using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.Models
{
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
