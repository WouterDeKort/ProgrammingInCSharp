using System;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective4
{
    [Description("Listing 3-34 Checking for the debug symbol.")]
    internal class CheckingForTheDebugSymbol : ISample
    {
        public void Run()
        {
        }

        public void DebugDirective()
        {
#if DEBUG
            Console.WriteLine("Debug mode");
#else
        Console.WriteLine("Not debug");
#endif
        }
    }
}