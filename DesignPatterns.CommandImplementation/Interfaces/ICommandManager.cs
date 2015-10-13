using DesignPatterns.Interfaces;

namespace DesignPatterns.CommandImplementation.Interfaces
{
    /// <summary>
    /// This interface defines a sample command manager.
    /// </summary>
    public interface ICommandManager
    {
        /// <summary>
        /// The main execution method to decouple actions. Track
        /// commands in this method if you need to Undo or Redo actions.
        /// </summary>
        void Execute(ICommand command);

        /// <summary>
        /// Method to redo actions if needed.
        /// </summary>
        void Redo();

        /// <summary>
        /// Method to undo actions if needed.
        /// </summary>
        void Undo();

        /// <summary>
        /// Method to purge all commands from the manager object
        /// to avoid stack overflow. Use as needed from top level
        /// tracking objects. Might be worth calling every 50
        /// usages, etc.
        /// </summary>
        void PurgeCommands();

        /// <summary>
        /// Method to clear all commands from the manager object
        /// to avoid stack overflow. Use when done. Once this
        /// is called, Undo and Redo context should be gone
        /// along with all executed commands.
        /// </summary>
        void ClearCommands();
    }
}
