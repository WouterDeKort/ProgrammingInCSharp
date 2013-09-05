using System;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-52 Using an extension method.")]
    internal class UsingAnExtensionMethod : ISample
    {
        public void Run()
        {
            int x = 2;
            Console.WriteLine(x.Multiply(3));
        }
    }

    public static class IntExtensions
    {
        public static int Multiply(this int x, int y)
        {
            return x*y;
        }
    }
}