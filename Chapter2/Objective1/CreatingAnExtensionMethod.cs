using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    public class Product
    {
        public decimal Price { get; set; }
    }

    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price*.9M;
        }
    }

    [Description("Listing 2-16 Creating an extension method.")]
    internal class CreatingAnExtensionMethod : ISample
    {
        public void Run()
        {
        }

        public class Calculator
        {
            public decimal CalculateDiscount(Product p)
            {
                return p.Discount();
            }
        }
    }
}