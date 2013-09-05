using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-57 A more readable nested if statement.")]
    internal class ABetterReadableNestedIfStatement : ISample
    {
        public void Run()
        {
            bool x = true;
            bool y = false;

            if (x)
            {
                if (y)
                {
                    F();
                }
                else
                {
                    G();
                }
            }
        }

        private void F()
        {
            Console.WriteLine("F called");
        }

        private void G()
        {
            Console.WriteLine("G called");
        }
    }
}