using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-46 Inheriting from a base class.")]
    internal class InheritingFromABaseClass : ISample
    {
        public void Run()
        {
        }

        private interface IEntity
        {
            int Id { get; }
        }

        private class Order : IEntity
        {
            public int Id { get; set; }
        }

        private class OrderRepository : Repository<Order>
        {
            public OrderRepository(IEnumerable<Order> orders)
                : base(orders)
            {
            }

            public IEnumerable<Order> FilterOrdersOnAmount(decimal amount)
            {
                List<Order> result = null;
                // Some filtering code
                return result;
            }
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