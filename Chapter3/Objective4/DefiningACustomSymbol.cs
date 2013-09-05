#define MySymbol

using System;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective4
{
    [Description("Listing 3-35 Defining a custom symbol.")]
    internal class DefiningACustomSymbol : ISample
    {
        public void Run()
        {
        }


// ...

        public void UseCustomSymbol()
        {
#if MySymbol
            Console.WriteLine("Custom symbol is defined");
#endif
        }
    }
}