using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-45 Creating a base class.")]
    internal class CreatingABaseClass : ISample
    {
        public void Run()
        {
        }

        private interface IEntity
        {
            int Id { get; }
        }

        private class Repository<T>
            where T : IEntity
        {
            protected readonly IEnumerable<T> _elements;

            public Repository(IEnumerable<T> elements)
            {
                _elements = elements;
            }

            public T FindById(int id)
            {
                return _elements.SingleOrDefault(e => e.Id == id);
            }
        }
    }
}