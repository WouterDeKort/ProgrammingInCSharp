using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective5
{
    [Description("Listing 1-92 Using Environment.FailFast.")]
    internal class UsingEnvironmentFailFast : ISample
    {
        public void Run()
        {
            Console.WriteLine("Please enter a number. Enter 42 to fail fast.");
            string s = Console.ReadLine();

            try
            {
                int i = int.Parse(s);
                if (i == 42) Environment.FailFast("Special number entered");
            }
            finally
            {
                Console.WriteLine("Program complete.");
            }
        }
    }
}