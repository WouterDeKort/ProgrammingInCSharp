using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-46 Using the equality operator.")]
    internal class UsingTheEqualityOperator : ISample
    {
        public void Run()
        {
            int x = 42;
            int y = 1;
            int z = 42;

            Console.WriteLine(x == y);
            Console.WriteLine(x == z);
        }
    }
}