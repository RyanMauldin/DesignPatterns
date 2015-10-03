using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethodImplementation
{
    public class NormalPersonFactoryMethod : FactoryMethod<NormalPerson>
    {
        public override NormalPerson Create()
        {
            return new NormalPerson();
        }
    }
}
