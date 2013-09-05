using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-94 Changing a string with a regular expression.")]
    internal class ChangingAStringWithARegularExpression : ISample
    {
        public void Run()
        {
            string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
            string[] names =
            {
                "Mr. Henry Hunt", "Ms. Sara Samuels",
                "Abraham Adams", "Ms. Nicole Norris"
            };

            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));
        }
    }
}