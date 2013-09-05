using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-64 A basic for loop.")]
    internal class ABasicForLoop : ISample
    {
        public void Run()
        {
            int[] values = {1, 2, 3, 4, 5, 6};
            for (int index = 0; index < values.Length; index++)
            {
                Console.Write(values[index]);
            }
            Console.WriteLine();
        }
    }
}