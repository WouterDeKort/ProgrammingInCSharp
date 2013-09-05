using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-100 Creating a composite string formatting.")]
    internal class CreatingACompositeStringFormatting : ISample
    {
        public void Run()
        {
            int a = 1;
            int b = 2;
            string result = string.Format("a: {0}, b: {1}", a, b);
            Console.WriteLine(result);
        }
    }
}