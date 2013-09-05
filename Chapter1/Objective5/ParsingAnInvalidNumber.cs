using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective5
{
    [Description("Listing 1-88 Parsing an invalid number.")]
    internal class ParsingAnInvalidNumber : ISample
    {
        public void Run()
        {
            string s = "NaN";
            try
            {
                int i = int.Parse(s);
            }
            catch
            {
                Console.WriteLine("Number parsing failed");
            }
        }
    }
}