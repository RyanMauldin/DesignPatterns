using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethodImplementation
{
    /// <summary>
    /// Factory method pattern for NormalPerson objects.
    /// </summary>
    public class NormalPersonFactoryMethod :
        FactoryMethod<NormalPerson>
    {
        /// <summary>
        /// Creates a new instance of NormalPerson.
        /// </summary>
        /// <returns>A newed up instance of type NormalPerson.</returns>
        public override NormalPerson Create()
        {
            return new NormalPerson();
        }
    }
}
