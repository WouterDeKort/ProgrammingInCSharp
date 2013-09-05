using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-23 Unordered parallel query.")]
    internal class UnorderedParallelQuery : ISample
    {
        public void Run()
        {
            IEnumerable<int> numbers = Enumerable.Range(0, 10);
            int[] parallelResult = numbers.AsParallel()
                .Where(i => i%2 == 0)
                .ToArray();

            foreach (int i in parallelResult)
                Console.WriteLine(i);
        }
    }
}