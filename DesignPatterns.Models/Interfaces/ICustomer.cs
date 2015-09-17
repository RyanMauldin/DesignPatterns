namespace DesignPatterns.Models.Interfaces
{
    public interface ICustomer : IPerson, IEntity
    {
        string AccountNumber { get; set; }
        string Company { get; set; }
    }
}
