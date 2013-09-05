using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective2
{
    [Description("Listing 1-43 Throwing OperationCanceledException.")]
    internal class ThrowingOperationCanceledException : ISample
    {
        public void Run()
        {
            var cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }

                token.ThrowIfCancellationRequested();
            }, token);

            try
            {
                Console.WriteLine("Press enter to stop the task");
                Console.ReadLine();

                cancellationTokenSource.Cancel();
                task.Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions[0].Message);
            }
        }
    }
}