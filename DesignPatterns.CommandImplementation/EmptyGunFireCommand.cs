using System.Text;

namespace DesignPatterns.CommandImplementation
{
    public class EmptyGunFireCommand :
        Command
    {
        private readonly StringBuilder _builder;

        public EmptyGunFireCommand(StringBuilder builder)
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
                _builder.AppendLine("Clink");
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
                _builder.AppendLine("Undo Clink");
            }   
        }
    }
}
