using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-54 Code blocks and scoping.")]
    internal class CodeBlocksAndScoping : ISample
    {
        public void Run()
        {
            bool b = true;
            if (b)
            {
                int r = 42;
                b = false;
            }

            //Console.WriteLine(r); // This line will give compile error
            Console.WriteLine(b);
        }
    }
}