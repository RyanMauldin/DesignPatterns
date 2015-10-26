using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    public abstract class StateContext :
        IStateContext
    {
        public IState CurrentState { get; set; }
    }
}
