using System.Text;
using DesignPatterns.CommandImplementation.Interfaces;
using DesignPatterns.Interfaces;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    /// <summary>
    /// The Command Pattern Example.
    /// </summary>
    public class CommandPatternExample :
        DesignPatternExample
    {
        private readonly ICommandManager _commandManager;
        private readonly ICommand _skipCommand;
        private readonly ICommand _hitCommand;
        private readonly ICommand _shootCommand;

        public CommandPatternExample(
            ICommandManager commandManager,
            ICommand skipCommand,
            ICommand hitCommand,
            ICommand shootCommand)
        {
            _commandManager = commandManager;
            _skipCommand = skipCommand;
            _hitCommand = hitCommand;
            _shootCommand = shootCommand;
        }

        /// <summary>
        /// The run method, runs your example design pattern
        /// and gathers output for the Console in the
        /// passed in StringBuilder.
        /// </summary>
        /// <param name="builder">The StringBuilder to gather output for the Console.</param>
        public override void Run(StringBuilder builder)
        {
            base.Run(builder);
            lock (builder)
            {
                _commandManager.Execute(_skipCommand);
                _commandManager.Execute(_skipCommand);
                _commandManager.Execute(_hitCommand);
                _commandManager.Execute(_skipCommand);
                _commandManager.Execute(_skipCommand);
                _commandManager.Execute(_shootCommand);
                _commandManager.Execute(_skipCommand);
                _commandManager.Execute(_skipCommand);
                _commandManager.Execute(_hitCommand);
                _commandManager.Undo();
                _commandManager.Undo();
                _commandManager.Undo();
                _commandManager.Undo();
                _commandManager.Redo();
                _commandManager.Redo();
                _commandManager.Redo();
                _commandManager.Redo();
                _commandManager.Undo();
                _commandManager.Undo();
                _commandManager.Undo();
                _commandManager.Undo();
                _commandManager.Undo();
                _commandManager.Undo();
                _commandManager.Undo();
                _commandManager.Undo();
                _commandManager.Undo();
                _commandManager.Execute(_skipCommand);
                _commandManager.Execute(_skipCommand);
                _commandManager.Execute(_skipCommand);
                _commandManager.Execute(_skipCommand);
                _commandManager.Execute(_skipCommand);
                _commandManager.Execute(_hitCommand);
                _commandManager.Execute(_shootCommand);
                _commandManager.PurgeCommands(); // should be a few remaining based on app.config MaximumCommandStackSize value.
                _commandManager.ClearCommands(); // free's all references to stored commands.
            }
        }
    }
}
