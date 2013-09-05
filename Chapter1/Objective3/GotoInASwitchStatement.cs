using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-63 goto in a switch statement")]
    internal class GotoInASwitchStatement : ISample
    {
        public void Run()
        {
            int i = 1;
            switch (i)
            {
                case 1:
                {
                    Console.WriteLine("Case 1");
                    goto case 2;
                }
                case 2:
                {
                    Console.WriteLine("Case 2");
                    break;
                }
            }
        }
    }
}