using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-27 Catching AggregateException.")]
    internal class CatchingAggregateException : ISample
    {
        public void Run()
        {
            IEnumerable<int> numbers = Enumerable.Range(0, 20);
            try
            {
                ParallelQuery<int> parallelResult = numbers.AsParallel()
                    .Where(IsEven);

                parallelResult.ForAll(Console.WriteLine);
            }
            catch (AggregateException e)
            {
                Console.WriteLine("There where {0} exceptions",
                    e.InnerExceptions.Count);
            }
        }

        public static bool IsEven(int i)
        {
            if (i%10 == 0) throw new ArgumentException("i");

            return i%2 == 0;
        }
    }
}