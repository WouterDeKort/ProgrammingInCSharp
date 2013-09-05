using System;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective4
{
    [Description("Listing 3-41 Call a method only in a debug build.")]
    internal class CallAMethodOnlyInADebugBuild : ISample
    {
        public void Run()
        {
        }

        public void SomeMethod()
        {
#if DEBUG
            Log("Step1");
#endif
        }

        private static void Log(string message)
        {
            Console.WriteLine("message");
        }
    }
}