using System;
using System.ComponentModel;
using System.Threading;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-3 Using the ParameterizedThreadStart.")]
    internal class UsingTheParameterizedThreadStart : ISample
    {
        public void Run()
        {
            var t = new Thread(ThreadMethod);
            t.Start(5);
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