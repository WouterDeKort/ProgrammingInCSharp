using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-21 Continuing on a thread pool instead of the UI thread.")]
    internal class ContinuingOnAThreadPoolInsteadOfTheUIThread : ISample
    {
        public void Run()
        {
            Console.WriteLine("Please launch the standalone WPF application for this sample");
        }
    }
}