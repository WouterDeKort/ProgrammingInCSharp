using System;
using System.ComponentModel;
using System.Globalization;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-6 Using configuration options when parsing a number.")]
    internal class UsingConfigurationOptionsWhenParsingANumber : ISample
    {
        public void Run()
        {
            var english = new CultureInfo("En");
            var dutch = new CultureInfo("Nl");

            string value = "€19,95";
            decimal d = decimal.Parse(value, NumberStyles.Currency, dutch);
            Console.WriteLine(d.ToString(english));
        }
    }
}