using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective2
{
    [Description("Listing 1-44 Adding a continuation for canceled tasks.")]
    internal class AddingAContinuationForCanceledTasks : ISample
    {
        public void Run()
        {
            var cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            Task task = Task.Run(() =>
            {
                while (true)
                {
                    token.ThrowIfCancellationRequested();
                
                    Console.Write("*");
                    Thread.Sleep(1000);
                }

            }, token)
                .ContinueWith(t => { Console.WriteLine("You have canceled the task"); },
                    TaskContinuationOptions.OnlyOnCanceled);

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();

            cancellationTokenSource.Cancel();
        }
    }
}