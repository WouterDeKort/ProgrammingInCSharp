using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-3 Calling a method.")]
    internal class CallingAMethod : ISample
    {
        public void Run()
        {
            Console.WriteLine("I’m calling a method!");
        }
    }
}