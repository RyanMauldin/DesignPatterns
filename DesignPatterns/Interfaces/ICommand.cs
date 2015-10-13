namespace DesignPatterns.Interfaces
{
    /// <summary>
    /// Intent - The Command Pattern allows for an action to be
    /// decoupled from it's sender. Actions shold be invoked via
    /// the Execute() method. As such, I did not make this
    /// interface reference any parameters or generic types.
    /// Although this interface could allow for parameter
    /// targets, I wanted to keep this code as simple as
    /// possible. As well, I added Undo and Redo to the
    /// interface for common usage scenarios, although Execute()
    /// method alone could suffice to accomplish the pattern.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// The main execution method to decouple actions.
        /// </summary>
        void Execute();

        /// <summary>
        /// Method to redo actions if needed.
        /// </summary>
        void Redo();

        /// <summary>
        /// Method to undo actions if needed.
        /// </summary>
        void Undo();
    }
}