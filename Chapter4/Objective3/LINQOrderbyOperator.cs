using System;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-57 LINQ orderby operator")]
    internal class LINQOrderbyOperator : ISample
    {
        public void Run()
        {
            int[] data = {1, 2, 5, 8, 11};
            IOrderedEnumerable<int> result = from d in data
                where d > 5
                orderby d descending
                select d;
            Console.WriteLine(string.Join(", ", result));
        }
    }
}