using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-17 Using Parallel.Break")]
    internal class UsingParallelBreak : ISample
    {
        public void Run()
        {
            ParallelLoopResult result = Parallel.For(
                0,
                1000,
                (int i, ParallelLoopState loopState) =>
                {
                    if (i == 500)
                    {
                        Console.WriteLine("Breaking loop");
                        loopState.Break();
                    }
                });
        }
    }
}