using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-24 Ordered parallel query.")]
    internal class OrderedParallelQuery : ISample
    {
        public void Run()
        {
            IEnumerable<int> numbers = Enumerable.Range(0, 10);
            int[] parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i%2 == 0)
                .ToArray();

            foreach (int i in parallelResult)
                Console.WriteLine(i);
        }
    }
}