using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-9 Starting a new Task")]
    internal class StartingANewTaskII : ISample
    {
        public void Run()
        {
            Task<int> t = Task.Run(() => { return 42; });
            Console.WriteLine(t.Result); // Displays 42
        }
    }
}