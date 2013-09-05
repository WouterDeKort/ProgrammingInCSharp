using System;
using System.ComponentModel;
using System.Globalization;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-98 Displaying a DateTime with different format strings.")]
    internal class DisplayingADateTimeWithDifferentFormatStrings : ISample
    {
        public void Run()
        {
            var d = new DateTime(2013, 4, 22);
            var provider = new CultureInfo("en-US");
            Console.WriteLine(d.ToString("d", provider));
            Console.WriteLine(d.ToString("D", provider));
            Console.WriteLine(d.ToString("M", provider));
        }
    }
}