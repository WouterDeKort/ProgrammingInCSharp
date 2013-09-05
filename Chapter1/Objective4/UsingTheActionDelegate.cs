using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-81 Using the Action delegate.")]
    internal class UsingTheActionDelegate : ISample
    {
        public void Run()
        {
            Action<int, int> calc = (x, y) => { Console.WriteLine(x + y); };

            calc(3, 4);
        }
    }
}