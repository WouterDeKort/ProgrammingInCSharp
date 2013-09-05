using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-62 Using Skip and Take to implement paging.")]
    internal class UsingSkipAndTakeToImplementPaging : ISample
    {
        public void Run()
        {
            var p1 = new Product {Description = "p1", Price = 1};
            var p2 = new Product {Description = "p2", Price = 2};
            var p3 = new Product {Description = "p3", Price = 3};
            var p4 = new Product {Description = "p4", Price = 4};
            var p5 = new Product {Description = "p5", Price = 5};


            var orders = new List<Order>
            {
                new Order
                {
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine
                        {
                            Amount = 5,
                            Product = p1
                        },
                        new OrderLine
                        {
                            Amount = 3,
                            Product = p4
                        }
                    }
                },
                new Order
                {
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine
                        {
                            Amount = 2,
                            Product = p2
                        }
                    }
                }
                ,
                new Order
                {
                    OrderLines = new List<OrderLine>
                    {
                        new OrderLine
                        {
                            Amount = 3,
                            Product = p3
                        },
                        new OrderLine
                        {
                            Amount = 1,
                            Product = p5
                        }
                    }
                }
            };
            int pageIndex = 2;
            int pageSize = 2;
            IEnumerable<Order> pagedOrders = orders
                .Skip((pageIndex - 1)*pageSize)
                .Take(pageSize);
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