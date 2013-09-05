using System;
using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-54 A LINQ select query.")]
    internal class ALINQSelectQuery : ISample
    {
        public void Run()
        {
            int[] data = {1, 2, 5, 8, 11};

            IEnumerable<int> result = from d in data
                where d%2 == 0
                select d;

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

        }
    }
}