using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-59 Nesting the null-coalescing operator")]
    internal class NestingTheNullCoalescingOperator : ISample
    {
        public void Run()
        {
            int? x = null;
            int? z = null;
            int y = x ??
                    z ??
                    -1;

            Console.WriteLine(y);
        }
    }
}