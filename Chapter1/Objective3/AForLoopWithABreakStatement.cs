using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-67 A for loop with a break statement.")]
    internal class AForLoopWithABreakStatement : ISample
    {
        public void Run()
        {
            int[] values = {1, 2, 3, 4, 5, 6};
            for (int index = 0; index < values.Length; index++)
            {
                if (values[index] == 4) break;

                Console.Write(values[index]);
            }

            Console.WriteLine();
        }
    }
}