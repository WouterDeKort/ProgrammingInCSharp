using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-26 Using ForAll.")]
    internal class UsingForAll : ISample
    {
        public void Run()
        {
            IEnumerable<int> numbers = Enumerable.Range(0, 20);

            ParallelQuery<int> parallelResult = numbers.AsParallel()
                .Where(i => i%2 == 0);

            parallelResult.ForAll(e => Console.WriteLine(e));
        }
    }
}