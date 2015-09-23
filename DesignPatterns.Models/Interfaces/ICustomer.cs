namespace DesignPatterns.Models.Interfaces
{
    public interface ICustomer : IPerson
    {
        string AccountNumber { get; set; }
        string Company { get; set; }
    }
}
