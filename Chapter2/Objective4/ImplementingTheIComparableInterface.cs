using System;
using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-54 Implementing the IComparable interface.")]
    internal class ImplementingTheIComparableInterface : ISample
    {
        public void Run()
        {
            var orders = new List<Order>
            {
                new Order {Created = new DateTime(2012, 12, 1)},
                new Order {Created = new DateTime(2012, 1, 6)},
                new Order {Created = new DateTime(2012, 7, 8)},
                new Order {Created = new DateTime(2012, 2, 20)},
            };

            orders.Sort();
        }

        private class Order : IComparable
        {
            public DateTime Created { get; set; }

            public int CompareTo(object obj)
            {
                if (obj == null) return 1;

                var o = obj as Order;

                if (o == null)
                {
                    throw new ArgumentException("Object is not an Order");
                }


                return Created.CompareTo(o.Created);
            }
        }
    }
}