using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-74 goto statement with a label.")]
    internal class GotoStatementWithALabel : ISample
    {
        public void Run()
        {
            int x = 3;
            if (x == 3)
                goto customLabel;

            x++;

            customLabel:
            Console.WriteLine(x);
        }
    }
}