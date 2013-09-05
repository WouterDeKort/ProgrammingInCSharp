using System;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-51 Using an anonymous method")]
    internal class UsingAnAnonymousMethod : ISample
    {
        public void Run()
        {
            Func<int, int> myDelegate =
                delegate(int x) { return x*2; };
            Console.WriteLine(myDelegate(21));
        }
    }
}