using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-47 Boolean OR operator.")]
    internal class BooleanOROperator : ISample
    {
        public void Run()
        {
            bool x = true;
            bool y = false;

            bool result = x || y;
            Console.WriteLine(result);
        }
    }
}