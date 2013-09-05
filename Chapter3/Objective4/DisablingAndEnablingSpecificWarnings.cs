using System;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective4
{
    [Description("Listing 3-40 Disabling and enabling specific warnings.")]
    internal class DisablingAndEnablingSpecificWarnings : ISample
    {
        public void Run()
        {
#pragma warning disable 0162, 0168
            int i;
#pragma warning restore 0162
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore         }
        }
    }
}