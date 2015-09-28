using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.ConsoleApplication.DesignPatternExamples
{
    public class PersonBehaviorExample : DesignPatternExample
    {
        private readonly IPerson _person;

        public PersonBehaviorExample(
            IPerson person)
        {
            _person = person;
        }

        public override void Run(StringBuilder builder)
        {
            base.Run(builder);
            _person.Idle(builder);
            _person.Still(builder);
            _person.Walk(builder);
            _person.Run(builder);
            _person.Drive(builder);
        }
    }
}
