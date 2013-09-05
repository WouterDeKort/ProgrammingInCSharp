using System;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-7 Using Convert with a null value.")]
    internal class UsingConvertWithANullValue : ISample
    {
        public void Run()
        {
            int i = Convert.ToInt32(null);
            Console.WriteLine(i);
        }
    }
}