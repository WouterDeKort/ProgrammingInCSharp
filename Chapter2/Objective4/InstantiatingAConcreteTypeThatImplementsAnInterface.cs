using System.ComponentModel;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-44 Instantiating a concrete type that implements an interface.")]
    internal class InstantiatingAConcreteTypeThatImplementsAnInterface : ISample
    {
        public void Run()
        {
            IAnimal animal = new Dog();
            animal.Move();
        }

        private class Dog : IAnimal
        {
            public void Move()
            {
            }

            public void Bark()
            {
            }
        }

        private interface IAnimal
        {
            void Move();
        }
    }
}