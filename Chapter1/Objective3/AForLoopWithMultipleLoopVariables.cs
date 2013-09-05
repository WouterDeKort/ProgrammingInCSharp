using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-65 A for loop with multiple loop variables.")]
    internal class AForLoopWithMultipleLoopVariables : ISample
    {
        public void Run()
        {
            int[] values = {1, 2, 3, 4, 5, 6};
            for (int x = 0, y = values.Length - 1;
                ((x < values.Length) && (y >= 0));
                x++, y--)
            {
                Console.Write(values[x]);
                Console.Write(values[y]);
            }

            Console.WriteLine();
        }
    }
}