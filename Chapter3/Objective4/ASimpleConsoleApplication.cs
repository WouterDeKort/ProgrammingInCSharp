using System;
using System.ComponentModel;
using System.Threading;
using Startup;

namespace Chapter3.Objective4
{
    [Description("Listing 3-33 A simple console application.")]
    internal class ASimpleConsoleApplication : ISample
    {
        public void Run()
        {
            var t = new Timer(TimerCallback, null, 0, 2000);
            Console.ReadLine();
        }

        private static void TimerCallback(Object o)
        {
            Console.WriteLine("In TimerCallback: " + DateTime.Now);
            GC.Collect();
        }
    }
}