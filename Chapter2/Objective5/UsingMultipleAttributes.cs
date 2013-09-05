using System.ComponentModel;
using System.Diagnostics;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-59 Using multiple attributes.")]
    internal class UsingMultipleAttributes : ISample
    {
        public void Run()
        {
        }

        [Conditional("CONDITION1"), Conditional("CONDITION2")]
        private static void MyMethod()
        {
        }
    }
}