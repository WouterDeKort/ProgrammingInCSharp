using System;
using System.ComponentModel;
using System.Threading;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-6 Using ThreadLocal<T>.")]
    internal class UsingThreadLocalOfT : ISample
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() => { return Thread.CurrentThread.ManagedThreadId; });

        public void Run()
        {
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}