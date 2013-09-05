using System;
using System.ComponentModel;
using System.Threading;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-4 Stopping a thread.")]
    internal class StoppingAThread : ISample
    {
        public void Run()
        {
            bool stopped = false;
            var t = new Thread(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            });

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }

        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int) o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}