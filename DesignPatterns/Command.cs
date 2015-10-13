using DesignPatterns.Interfaces;

namespace DesignPatterns
{
    /// <summary>
    /// Intent - The Command Pattern allows for an action to be
    /// decoupled from it's sender. This is an example base
    /// class to derive from to give an example command. See
    /// interface for further definition.
    /// </summary>
    public abstract class Command :
        ICommand
    {
        /// <summary>
        /// The main execution method to decouple actions.
        /// </summary>
        public abstract void Execute();

        /// <summary>
        /// Method to redo actions if needed.
        /// </summary>
        public abstract void Redo();

        /// <summary>
        /// Method to undo actions if needed.
        /// </summary>
        public abstract void Undo();
    }
}
