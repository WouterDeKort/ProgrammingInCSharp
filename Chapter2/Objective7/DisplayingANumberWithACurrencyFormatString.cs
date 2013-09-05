using System;
using System.ComponentModel;
using System.Globalization;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-97 Displaying a number with a currency format string.")]
    internal class DisplayingANumberWithACurrencyFormatString : ISample
    {
        public void Run()
        {
            double cost = 1234.56;
            Console.WriteLine(cost.ToString("C",
                new CultureInfo("en-US")));
        }
    }
}