using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-22 Using AsParallel.")]
    internal class UsingAsParallel : ISample
    {
        public void Run()
        {
            IEnumerable<int> numbers = Enumerable.Range(0, 100000000);
            int[] parallelResult = numbers.AsParallel()
                .Where(i => i%2 == 0)
                .ToArray();
        }
    }
}