using System;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective4
{
    [Description("Listing 3-39 The pragma warning directive.")]
    internal class ThePragmaWarningDirective : ISample
    {
        public void Run()
        {
#pragma warning disable
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore        }
        }
    }
}