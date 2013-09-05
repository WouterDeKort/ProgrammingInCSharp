using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-25 Making a parallel query sequential.")]
    internal class MakingAParallelQuerySequential : ISample
    {
        public void Run()
        {
            IEnumerable<int> numbers = Enumerable.Range(0, 20);

            IEnumerable<int> parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i%2 == 0).AsSequential();

            foreach (int i in parallelResult.Take(5))
                Console.WriteLine(i);
        }
    }
}