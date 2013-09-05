using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-79 Lambda expression to create a delegate.")]
    internal class LambdaExpressionToCreateADelegate : ISample
    {
        public delegate int Calculate(int x, int y);

        public void Run()
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4)); // Displays 7

            calc = (x, y) => x*y;
            Console.WriteLine(calc(3, 4)); // Displays 12
        }
    }
}