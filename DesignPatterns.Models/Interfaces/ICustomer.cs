namespace DesignPatterns.Models.Interfaces
{
    // Sample interface for adapters and such.
    public interface ICustomer : IPerson
    {
        string AccountNumber { get; set; }
        string Company { get; set; }
    }
}
