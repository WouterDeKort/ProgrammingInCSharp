using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-13 Using a TaskFactory.")]
    internal class UsingATaskFactory : ISample
    {
        public void Run()
        {
            Task<Int32[]> parent = Task.Factory.StartNew(() =>
            {
                var results = new Int32[3];

                var tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
                    TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => { Thread.Sleep(1000); results[0] = 0; });
                tf.StartNew(() => { Thread.Sleep(1000); results[1] = 1; });
                tf.StartNew(() => { Thread.Sleep(1000); results[2] = 2; });
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