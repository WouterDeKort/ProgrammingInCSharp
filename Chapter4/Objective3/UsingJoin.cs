using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-61 Using join.")]
    internal class UsingJoin : ISample
    {
        public void Run()
        {
            var products = new List<Product>
            {
                new Product {Description = "A", Price = 1},
                new Product {Description = "B", Price = 2},
                new Product {Description = "C", Price = 3},
            };

            string[] popularProductNames = {"A", "B"};
            IEnumerable<Product> popularProducts = from p in products
                join n in popularProductNames on p.Description equals n
                select p;
        }

        public class Product
        {
            public string Description { get; set; }
            public decimal Price { get; set; }
        }
    }
}