using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-12 Attaching child tasks to a parent task.")]
    internal class AttachingChildTasksToAParentTask : ISample
    {
        public void Run()
        {
            Task<Int32[]> parent = Task.Factory.StartNew(() =>
            {
                var results = new Int32[3];
                new Task(() => { Thread.Sleep(1000); results[0] = 0; },
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => { Thread.Sleep(1000); results[1] = 1; }, 
                    TaskCreationOptions.AttachedToParent).Start();
                new Task(() => { Thread.Sleep(1000); results[2] = 2; }, 
                    TaskCreationOptions.AttachedToParent).Start();


                return results;
            });
            Task finalTask = parent.ContinueWith(
                parentTask =>
                {
                    foreach (int i in parentTask.Result)
                        Console.WriteLine(i);
                });

            finalTask.Wait();
        }
    }
}