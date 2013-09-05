using System;
using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective5
{
    [Description("Listing 4-87 Using HashSet<T>.")]
    internal class UsingHashSetT : ISample
    {
        public void Run()
        {
            var oddSet = new HashSet<int>();
            var evenSet = new HashSet<int>();

            for (int x = 1; x <= 10; x++)
            {
                if (x%2 == 0)
                    evenSet.Add(x);
                else
                    oddSet.Add(x);
            }

            DisplaySet(oddSet);
            DisplaySet(evenSet);

            oddSet.UnionWith(evenSet);
            DisplaySet(oddSet);
        }

        private void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int i in set)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }
    }
}