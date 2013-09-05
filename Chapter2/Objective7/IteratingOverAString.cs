using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-95 Iterating over a string.")]
    internal class IteratingOverAString : ISample
    {
        public void Run()
        {
            string value = "My Custom Value";
            foreach (char c in value)
                Console.WriteLine(c);
        }
    }
}