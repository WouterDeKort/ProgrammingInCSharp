using System;
using System.ComponentModel;
using System.Threading;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-7 Queuing some work to the thread pool.")]
    internal class QueuingSomeWorkToTheThreadPool : ISample
    {
        public void Run()
        {
            ThreadPool.QueueUserWorkItem(s => Console.WriteLine("Working on a thread from threadpool"));

            Console.ReadLine();
        }
    }
}