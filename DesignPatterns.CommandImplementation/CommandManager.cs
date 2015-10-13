using System.Collections.Concurrent;
using System.Linq;
using DesignPatterns.CommandImplementation.Interfaces;
using DesignPatterns.Interfaces;

namespace DesignPatterns.CommandImplementation
{
    /// <summary>
    /// This class is an example command manager. This code is
    /// thread safe and shows how to maintain a sample
    /// relationship between commands in a context. This code
    /// will Stack Overflow if Purge Commands is not used
    /// every once and a while. Note: This is just a sample
    /// usage. Keep track of object sizes from a top level
    /// object and Purge collections as needed to keep
    /// up performance and memory consumption. i.e. every
    /// 50 command exectues
    /// </summary>
    public class CommandManager :
        ICommandManager
    {
        public readonly int MaximumCommandStackSize;
        public ConcurrentStack<ICommand> Commands { get; set; }
        public ConcurrentStack<ICommand> UndoneCommands { get; set; }
        public ConcurrentStack<ICommand> RedoneCommands { get; set; }

        /// <summary>
        /// Specific constructor to provide Maxium Stack Size.
        /// </summary>
        /// <param name="maximumCommandStackSize">The default stack size is 50, unless a positive value is provided.</param>
        public CommandManager(int maximumCommandStackSize)
        {
            MaximumCommandStackSize = maximumCommandStackSize > 0
                ? maximumCommandStackSize
                : 50;
            Commands = new ConcurrentStack<ICommand>();
            UndoneCommands = new ConcurrentStack<ICommand>();
            RedoneCommands = new ConcurrentStack<ICommand>();
        }

        /// <summary>
        /// The main execution method to decouple actions. Track
        /// commands in this method if you need to Undo or Redo actions.
        /// </summary>
        public void Execute(ICommand command)
        {
            command.Execute();
            UndoneCommands.Clear();
            RedoneCommands.Clear();
            Commands.Push(command);
        }

        /// <summary>
        /// Method to redo actions if needed.
        /// </summary>
        public void Redo()
        {
            ICommand command;
            UndoneCommands.TryPop(out command);
            if (command == null)
                return;

            command.Redo();
            RedoneCommands.Push(command);
        }

        /// <summary>
        /// Method to undo actions if needed.
        /// </summary>
        public void Undo()
        {
            ICommand command;
            RedoneCommands.TryPop(out command);
            if (command == null)
                Commands.TryPop(out command);
            if (command == null)
                return;

            command.Undo();
            UndoneCommands.Push(command);
        }

        /// <summary>
        /// Method to purge all commands from the manager object
        /// to avoid stack overflow. Use as needed from top level
        /// tracking objects. Might be worth calling every 50
        /// usages, etc to free up memory.
        /// </summary>
        public void PurgeCommands()
        {
            if (RedoneCommands.Count > MaximumCommandStackSize)
            {
                var commands = RedoneCommands.Take(MaximumCommandStackSize).Reverse().ToArray();
                RedoneCommands.Clear();
                RedoneCommands.PushRange(commands);
            }

            if (UndoneCommands.Count > MaximumCommandStackSize)
            {
                var commands = UndoneCommands.Skip(MaximumCommandStackSize).ToArray();
                UndoneCommands.Clear();
                UndoneCommands.TryPopRange(commands);
            }
            
            if (Commands.Count > MaximumCommandStackSize)
            {
                var commands = Commands.Take(MaximumCommandStackSize).Reverse().ToArray();
                Commands.Clear();
                Commands.PushRange(commands);
            }
        }

        /// <summary>
        /// Method to clear all commands from the manager object
        /// to avoid stack overflow. Use when done. Once this
        /// is called, Undo and Redo context should be gone
        /// along with all executed commands.
        /// </summary>
        public void ClearCommands()
        {
            RedoneCommands.Clear();
            UndoneCommands.Clear();
            Commands.Clear();
        }
    }
}
