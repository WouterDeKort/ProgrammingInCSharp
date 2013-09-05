using System;
using System.ComponentModel;
using System.Threading;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-2 Using a background thread.")]
    internal class UsingABackgroundThread : ISample
    {
        public void Run()
        {
            var t = new Thread(ThreadMethod);

            // Change to true to exit the application immediately
            t.IsBackground = false;
            t.Start();
        }

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
}