using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-53 An if statement with code block.")]
    internal class IfStatementWithCodeBlock : ISample
    {
        public void Run()
        {
            bool b = true;
            if (b)
            {
                Console.WriteLine("Both these lines");
                Console.WriteLine("Will be executed");
            }
        }
    }
}