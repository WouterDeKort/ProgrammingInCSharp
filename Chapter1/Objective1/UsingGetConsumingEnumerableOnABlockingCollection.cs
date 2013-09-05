using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-29 Using GetConsumingEnumerable on a BlockingCollection.")]
    internal class UsingGetConsumingEnumerableOnABlockingCollection : ISample
    {
        public void Run()
        {
            var col = new BlockingCollection<string>();

            col.Add("1");
            col.Add("2");
            col.Add("3");
            col.CompleteAdding();

            Task read = Task.Run(() =>
            {
                foreach (string v in col.GetConsumingEnumerable())
                    Console.WriteLine(v);
            });

            read.Wait();
        }
    }
}