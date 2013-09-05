using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-51 Using the XOR operator.")]
    internal class UsingTheXOROperator : ISample
    {
        public void Run()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a ^ a); // False
            Console.WriteLine(a ^ b); // True
            Console.WriteLine(b ^ b); // False
        }
    }
}