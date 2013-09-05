using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-60 The conditional operator")]
    internal class TheConditionalOperator : ISample
    {
        public void Run()
        {
            Console.WriteLine(GetValueA(false));
            Console.WriteLine(GetValueA(true));

            Console.WriteLine(GetValueB(false));
            Console.WriteLine(GetValueB(true));
        }

        private static int GetValueA(bool p)
        {
            if (p)
                return 1;
            return 0;
        }

        private static int GetValueB(bool p)
        {
            return p ? 1 : 0;
        }
    }
}