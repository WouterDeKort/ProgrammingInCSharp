using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-58 LINQ multiple from statements.")]
    internal class LINQMultipleFromStatements : ISample
    {
        public void Run()
        {
            int[] data1 = {1, 2, 5};
            int[] data2 = {2, 4, 6};

            IEnumerable<int> result = from d1 in data1
                from d2 in data2
                select d1*d2;

            Console.WriteLine(string.Join(", ", result));
        }
    }
}