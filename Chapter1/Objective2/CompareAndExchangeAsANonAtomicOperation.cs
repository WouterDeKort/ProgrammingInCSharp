using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective2
{
    [Description("Listing 1-41 Compare and exchange as a non-atomic operation.")]
    internal class CompareAndExchangeAsANonAtomicOperation : ISample
    {
        private static int value = 1;

        public void Run()
        {
            Task t1 = Task.Run(() =>
            {
                if (value == 1)
                {
                    // Removing the following line will change the output
                    Thread.Sleep(10000);
                    value = 2;
                }
            });

            // Use Interlocked:
            //Task t1 = Task.Run(() =>
            //{
            //    Thread.Sleep(1000);
            //    Interlocked.CompareExchange(ref value, 2, 1);
            //});

            Task t2 = Task.Run(() => { value = 3; });

            Task.WaitAll(t1, t2);
            Console.WriteLine(value); // Displays 2
        }
    }
}