using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective2
{
    [Description("Listing 1-35 Accessing shared data in a multithreaded application.")]
    internal class AccessingSharedDataInAMultithreadedApplication : ISample
    {
        public void Run()
        {
            int n = 0;

            Task up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    n++;
            });

            for (int i = 0; i < 1000000; i++)
                n--;

            up.Wait();
            Console.WriteLine(n);
        }
    }
}