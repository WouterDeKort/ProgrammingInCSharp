using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-69 A for loop as a while loop.")]
    internal class AForLoopAsAWhileLoop : ISample
    {
        public void Run()
        {
            int[] values = {1, 2, 3, 4, 5, 6};

            {
                int index = 0;
                while (index < values.Length)
                {
                    Console.Write(values[index]);
                    index++;
                }
            }
            Console.WriteLine();
        }
    }
}