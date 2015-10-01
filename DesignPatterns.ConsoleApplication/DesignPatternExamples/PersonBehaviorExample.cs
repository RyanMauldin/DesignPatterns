using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    /// <summary>
    /// The Person Behavior Example.
    /// </summary>
    public class PersonBehaviorExample : DesignPatternExample
    {
        private readonly IPerson _person;

        public PersonBehaviorExample(
            IPerson person)
        {
            _person = person;
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
            _person.Idle();
            _person.Still();
            _person.Walk();
            _person.Run();
            _person.Drive();
        }
    }
}
