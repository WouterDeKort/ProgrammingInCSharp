using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-11 Scheduling different continuation tasks")]
    internal class SchedulingDifferentContinuationTasks : ISample
    {
        public void Run()
        {
            Task<int> t = Task.Run(() => { return 42; });

            t.ContinueWith(i => { Console.WriteLine("Canceled"); }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith(i => { Console.WriteLine("Faulted"); }, TaskContinuationOptions.OnlyOnFaulted);

            Task completedTask = t.ContinueWith(i => { Console.WriteLine("Completed"); },
                TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
        }
    }
}