using System;
using System.ComponentModel;
using System.Threading;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-1 Creating a thread with the Thread class.")]
    internal class CreatingAThreadWithTheThreadClass : ISample
    {
        public void Run()
        {
            Console.WriteLine("Starting threads..");
            var t = new Thread(ThreadMethod);
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            t.Join();

            Console.WriteLine("Hit enter to exit");
            Console.ReadLine();
        }

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}