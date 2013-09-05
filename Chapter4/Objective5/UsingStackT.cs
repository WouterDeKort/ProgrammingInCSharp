using System;
using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective5
{
    [Description("Listing 4-89 Using Stack<T>.")]
    internal class UsingStackT : ISample
    {
        public void Run()
        {
            var myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("From");
            myStack.Push("A");
            myStack.Push("Queue");

            foreach (string s in myStack)
                Console.Write(s + " ");
            
        }
    }
}