using System;
using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-56 LINQ where operator.")]
    internal class LINQWhereOperator : ISample
    {
        public void Run()
        {
            int[] data = {1, 2, 5, 8, 11};
            IEnumerable<int> result = from d in data
                where d > 5
                select d;
            Console.WriteLine(string.Join(", ", result)); 
        }
    }
}