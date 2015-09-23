namespace DesignPatterns.Models.Interfaces
{
    public interface IPerson : IEntity
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
    }
}
