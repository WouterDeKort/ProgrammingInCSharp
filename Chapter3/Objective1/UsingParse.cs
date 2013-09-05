using System;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-4 Using Parse.")]
    internal class UsingParse : ISample
    {
        public void Run()
        {
            string value = "true";
            bool b = bool.Parse(value);
            Console.WriteLine(b);
        }
    }
}