using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-59 A sample Order class for LINQ queries.")]
    internal class ASampleOrderClassForLINQQueries : ISample
    {
        public void Run()
        {
        }

        public class Order
        {
            public List<OrderLine> OrderLines { get; set; }
        }

        public class OrderLine
        {
            public int Amount { get; set; }
            public Product Product { get; set; }
        }

        public class Product
        {
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
    }
}