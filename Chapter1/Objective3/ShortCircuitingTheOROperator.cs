using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-48 Short-circuiting the OR operator.")]
    internal class ShortCircuitingTheOROperator : ISample
    {
        public void Run()
        {
            bool x = true;
            bool result = x || GetY();
        }

        private bool GetY()
        {
            Console.WriteLine("This method doesn't get called");
            return true;
        }
    }
}