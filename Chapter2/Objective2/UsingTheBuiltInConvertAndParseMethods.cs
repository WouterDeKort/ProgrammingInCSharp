using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective2
{
    [Description("Listing 2-26 Using the built-in Convert and Parse methods")]
    internal class UsingTheBuiltInConvertAndParseMethods : ISample
    {
        public void Run()
        {
            int value = Convert.ToInt32("42");
            value = int.Parse("42");
            bool success = int.TryParse("42", out value);
        }
    }
}