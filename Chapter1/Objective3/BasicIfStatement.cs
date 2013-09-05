using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-52 Basic if statement")]
    internal class BasicIfStatement : ISample
    {
        public void Run()
        {
            bool b = true;
            if (b)
                Console.WriteLine("True");
        }
    }
}