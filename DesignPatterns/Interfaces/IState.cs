namespace DesignPatterns.Interfaces
{
    /// <summary>
    /// Intent - The State Pattern allows a State Context
    /// object to change its behavior when its Current State
    /// changes. This is much like the Strategy Pattern,
    /// however the States themselves change out the
    /// Strategy/State for the Current State on the
    /// State Context during program runtime. This is
    /// possible because States have access to the
    /// State Context and vice versa. This State
    /// interface has a reference to the State Context,
    /// so that at some point in the lifecycle of this
    /// State object, it can use the State Context to
    /// change out the State Context's Current State to
    /// another State object.
    /// Head First Design Patterns book definition -
    /// (ISBN: 978-0-596-00712-6)
    /// "The State Pattern allows an object to alter its
    /// behavior when its internal state changes. The
    /// object will appear to change its class."
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// The State Context is an interface which
        /// contains the Current State. Cast the
        /// State Context to the desired type to access
        /// other States present on the State Context.
        /// </summary>
        IStateContext StateContext { get; set; }
    }
}
