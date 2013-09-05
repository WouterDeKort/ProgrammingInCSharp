using System;
using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective5
{
    [Description("Listing 4-88 Using Queue<T>.")]
    internal class UsingQueueT : ISample
    {
        public void Run()
        {
            var myQueue = new Queue<string>();
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World");
            myQueue.Enqueue("From");
            myQueue.Enqueue("A");
            myQueue.Enqueue("Queue");

            foreach (string s in myQueue)
                Console.Write(s + " ");

        }
    }
}