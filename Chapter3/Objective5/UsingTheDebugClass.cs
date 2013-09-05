using System.ComponentModel;
using System.Diagnostics;
using Startup;

namespace Chapter3.Objective5
{
    [Description("Listing 3-45 Using the Debug class.")]
    internal class UsingTheDebugClass : ISample
    {
        public void Run()
        {
            Debug.WriteLine("Starting application");
            Debug.Indent();
            int i = 1 + 2;
            Debug.Assert(i == 3);
            Debug.WriteLineIf(i > 0, "i is greater than 0");
        }
    }
}