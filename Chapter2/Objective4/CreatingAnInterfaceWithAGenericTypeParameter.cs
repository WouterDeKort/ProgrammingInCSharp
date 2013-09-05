using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-43 Creating an interface with a generic type parameter.")]
    internal class CreatingAnInterfaceWithAGenericTypeParameter : ISample
    {
        public void Run()
        {
        }

        private interface IRepository<T>
        {
            T FindById(int id);
            IEnumerable<T> All();
        }
    }
}