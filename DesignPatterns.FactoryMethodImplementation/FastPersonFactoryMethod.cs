using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethodImplementation
{
    /// <summary>
    /// Factory method pattern for FastPerson objects.
    /// </summary>
    public class FastPersonFactoryMethod :
        FactoryMethod<FastPerson>
    {
        /// <summary>
        /// Creates a new instance of FastPerson.
        /// </summary>
        /// <returns>A newed up instance of type FastPerson.</returns>
        public override FastPerson Create()
        {
            return new FastPerson();
        }
    }
}
