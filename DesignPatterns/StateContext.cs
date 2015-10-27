using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    /// <summary>
    /// Intent - The State Pattern allows a State Context
    /// object to change its behavior when its Current State
    /// changes. This is much like the Strategy Pattern,
    /// however the States themselves change out the
    /// Strategy/State for the Current State on the
    /// State Context during program runtime. This is
    /// possible because States have access to the
    /// State Context and vice versa. When deriving from
    /// this abstract class, include all State objects as
    /// members, so that States can change the Current State
    /// of this State Context to another State during a
    /// State's lifecycle.
    /// Head First Design Patterns book definition -
    /// (ISBN: 978-0-596-00712-6)
    /// "The State Pattern allows an object to alter its
    /// behavior when its internal state changes. The
    /// object will appear to change its class."
    /// </summary>
    public abstract class StateContext :
        IStateContext
    {
        /// <summary>
        /// The Current State of the State Context.
        /// </summary>
        public IState CurrentState { get; set; }
    }
}
