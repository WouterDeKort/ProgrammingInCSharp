using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-71 foreach loop.")]
    internal class ForeachLoop : ISample
    {
        public void Run()
        {
            int[] values = {1, 2, 3, 4, 5, 6};

            foreach (int i in values)
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }
    }
}