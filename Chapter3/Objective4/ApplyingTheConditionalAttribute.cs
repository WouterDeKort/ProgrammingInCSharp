using System;
using System.ComponentModel;
using System.Diagnostics;
using Startup;

namespace Chapter3.Objective4
{
    [Description("Listing 3-42 Applying the ConditionalAttribute.")]
    internal class ApplyingTheConditionalAttribute : ISample
    {
        public void Run()
        {
            Log("Shows only in debug configuration.");
        }

        [Conditional("DEBUG")]
        private static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}