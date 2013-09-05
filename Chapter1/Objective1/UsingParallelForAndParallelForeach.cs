using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-16 Using Parallel.For and Parallel.Foreach")]
    internal class UsingParallelForAndParallelForeach : ISample
    {
        public void Run()
        {
            Parallel.For(0, 10, i => { Thread.Sleep(1000); });

            IEnumerable<int> numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i => { Thread.Sleep(1000); });
        }
    }
}