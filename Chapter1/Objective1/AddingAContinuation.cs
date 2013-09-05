using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-10 Adding a continuation.")]
    internal class AddingAContinuation : ISample
    {
        public void Run()
        {
            Task<int> t = Task.Run(() => 42).ContinueWith(i => i.Result*2);

            Console.WriteLine(t.Result); // Displays 84
        }
    }
}