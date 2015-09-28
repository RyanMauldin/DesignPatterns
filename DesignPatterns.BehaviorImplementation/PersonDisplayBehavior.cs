using System;
using System.Text;
using DesignPatterns.Models.Interfaces;

namespace DesignPatterns.BehaviorImplementation
{
    public abstract class PersonDisplayBehavior :
        Behavior<IPerson>
    {
        public override void Behave(IPerson target)
        {
            var builder = new StringBuilder();
            BehaveDebug(target, builder);
            Console.Write(builder);
        }
    }
}
