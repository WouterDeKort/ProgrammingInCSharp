using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective2
{
    [Description("Listing 1-37 Creating a deadlock.")]
    internal class CreatingADeadlock : ISample
    {
        public void Run()
        {
            Console.WriteLine(
                "This sample will cause a deadlock. You need to close the Console Application manually to exit.");
            var lockA = new object();
            var lockB = new object();

            Task up = Task.Run(() =>
            {
                lock (lockA)
                {
                    Console.WriteLine("Locked A");
                    Thread.Sleep(1000);
                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            lock (lockB)
            {
                Console.WriteLine("Locked B");
                Thread.Sleep(1000);
                lock (lockA)
                {
                    Console.WriteLine("Locked B and A");
                }
            }
            up.Wait();
        }
    }
}