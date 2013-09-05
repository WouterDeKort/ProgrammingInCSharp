using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-30 Using a ConcurrentBag.")]
    internal class UsingAConcurrentBag : ISample
    {
        public void Run()
        {
            var bag = new ConcurrentBag<int>();

            bag.Add(42);
            bag.Add(21);

            int result;
            if (bag.TryTake(out result))
                Console.WriteLine(result);

            if (bag.TryPeek(out result))
                Console.WriteLine("There is a next item: {0}", result);
        }
    }
}