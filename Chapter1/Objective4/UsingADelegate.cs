using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-75 Using a delegate.")]
    internal class UsingADelegate : ISample
    {
        public delegate int Calculate(int x, int y);

        public void Run()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4)); // Displays 7

            calc = Multiply;
            Console.WriteLine(calc(3, 4)); // Displays 12
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            return x*y;
        }
    }
}