using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethodImplementation
{
    public class FastPersonFactoryMethod :
        FactoryMethod<FastPerson>
    {
        public override FastPerson Create()
        {
            return new FastPerson();
        }
    }
}
