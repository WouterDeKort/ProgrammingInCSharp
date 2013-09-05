using System;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-8 Using Convert to convert from double to int.")]
    internal class UsingConvertToConvertFromDoubleToInt : ISample
    {
        public void Run()
        {
            double d = 23.15;
            int i = Convert.ToInt32(d);
            Console.WriteLine(i);
        }
    }
}