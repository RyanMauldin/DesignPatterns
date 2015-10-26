namespace DesignPatterns.Interfaces
{
    public interface IState
    {
        IStateContext StateContext { get; set; }
    }
}
