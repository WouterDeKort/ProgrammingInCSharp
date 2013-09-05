using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective1
{
    [Description("Listing 1-32 Using a ConcurrentStack.")]
    internal class UsingAConcurrentStack : ISample
    {
        public void Run()
        {
            var stack = new ConcurrentStack<int>();

            stack.Push(42);

            int result;
            if (stack.TryPop(out result))
                Console.WriteLine("Popped: {0}", result);

            stack.PushRange(new[] {1, 2, 3});

            var values = new int[2];
            stack.TryPopRange(values);

            foreach (int i in values)
                Console.WriteLine(i);
        }
    }
}