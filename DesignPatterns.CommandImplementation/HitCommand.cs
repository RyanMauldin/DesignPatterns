using System.Text;

namespace DesignPatterns.CommandImplementation
{
    /// <summary>
    /// Hit Command Example
    /// </summary>
    public class HitCommand
        : Command
    {
        private readonly StringBuilder _builder;

        public HitCommand(StringBuilder builder)
        {
            _builder = builder;
        }

        /// <summary>
        /// The main execution method to decouple actions.
        /// </summary>
        public override void Execute()
        {
            lock (_builder)
            {
                _builder.AppendLine("Blam");
            }
        }

        /// <summary>
        /// Method to redo actions if needed.
        /// </summary>
        public override void Redo()
        {
            Execute();
        }

        /// <summary>
        /// Method to undo actions if needed.
        /// </summary>
        public override void Undo()
        {
            lock (_builder)
            {
                _builder.AppendLine("Undo Blam");
            }   
        }
    }
}
