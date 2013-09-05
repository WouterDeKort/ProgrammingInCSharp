using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-55 LINQ Select operator.")]
    internal class LINQSelectOperator : ISample
    {
        public void Run()
        {
            int[] data = {1, 2, 5, 8, 11};
            IEnumerable<int> result = from d in data
                select d;
            Console.WriteLine(string.Join(", ", result)); 
        }
    }
}