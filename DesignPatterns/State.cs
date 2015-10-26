using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    public abstract class State :
        IState
    {
        public IStateContext StateContext { get; set; }
    }
}
