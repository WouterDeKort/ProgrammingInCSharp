using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective2
{
    [Description("Listing 1-45 Setting a timeout on a task.")]
    internal class SettingATimeoutOnATask : ISample
    {
        public void Run()
        {
            Task longRunning = Task.Run(() => { Thread.Sleep(10000); });

            int index = Task.WaitAny(new[] {longRunning}, 1000);

            if (index == -1)
                Console.WriteLine("Task timed out");
        }
    }
}