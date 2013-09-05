using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective2
{
    [Description("Listing 1-36 Using the lock keyword.")]
    internal class UsingTheLockKeyword : ISample
    {
        public void Run()
        {
            int n = 0;
            var _lock = new object();

            Task up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                    lock (_lock)
                        n++;
            });

            for (int i = 0; i < 1000000; i++)
                lock (_lock)
                    n--;

            up.Wait();
            Console.WriteLine(n);
        }
    }
}