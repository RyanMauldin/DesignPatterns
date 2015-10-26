namespace DesignPatterns.Interfaces
{
    public interface IStateContext
    {
        IState CurrentState { get; set; }
    }
}
