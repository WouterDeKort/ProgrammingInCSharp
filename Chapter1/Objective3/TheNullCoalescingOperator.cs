using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-58 The null-coalescing operator.")]
    internal class TheNullCoalescingOperator : ISample
    {
        public void Run()
        {
            int? x = null;
            int y = x ?? -1;

            Console.WriteLine(y);
        }
    }
}