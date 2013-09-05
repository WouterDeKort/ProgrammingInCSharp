using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-55 Using an else statement.")]
    internal class UsingAnElseStatement : ISample
    {
        public void Run()
        {
            bool b = false;

            if (b)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}