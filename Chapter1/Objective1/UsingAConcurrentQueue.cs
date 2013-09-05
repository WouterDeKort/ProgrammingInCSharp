using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-33 Using a ConcurrentQueue")]
    internal class UsingAConcurrentQueue : ISample
    {
        public void Run()
        {
            var queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int result;
            if (queue.TryDequeue(out result))
                Console.WriteLine("Dequeued: {0}", result);
        }
    }
}