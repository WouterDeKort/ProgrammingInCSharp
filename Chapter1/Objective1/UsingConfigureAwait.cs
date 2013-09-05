using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-20 Using ConfigureAwait")]
    internal class UsingConfigureAwait : ISample
    {
        public void Run()
        {
            Console.WriteLine("Please launch the standalone WPF application for this sample");
        }
    }
}