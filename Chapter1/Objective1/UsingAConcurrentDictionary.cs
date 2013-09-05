using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-34 Using a ConcurrentDictionary.")]
    internal class UsingAConcurrentDictionary : ISample
    {
        public void Run()
        {
            var dict = new ConcurrentDictionary<string, int>();
            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }
            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 updated to 21");
            }
            dict["k1"] = 42; // Overwrite unconditionally

            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i*2);
            int r2 = dict.GetOrAdd("k2", 3);
        }
    }
}