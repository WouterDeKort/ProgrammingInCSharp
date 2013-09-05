using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-70 do-while loop.")]
    internal class DoWhileLoop : ISample
    {
        public void Run()
        {
            do
            {
                Console.WriteLine("Executed once!");
            } while (false);
        }
    }
}