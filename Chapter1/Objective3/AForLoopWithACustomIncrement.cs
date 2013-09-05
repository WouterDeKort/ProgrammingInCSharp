using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-66 A for loop with a custom increment.")]
    internal class AForLoopWithACustomIncrement : ISample
    {
        public void Run()
        {
            int[] values = {1, 2, 3, 4, 5, 6};
            for (int index = 0; index < values.Length; index += 2)
            {
                Console.Write(values[index]);
            }

            Console.WriteLine();
        }
    }
}