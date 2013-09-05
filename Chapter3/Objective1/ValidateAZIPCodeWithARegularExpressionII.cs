using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-11 Validate a ZIP Code with a regular expression.")]
    internal class ValidateAZIPCodeWithARegularExpressionII : ISample
    {
        public void Run()
        {
            var options = RegexOptions.None;
            var regex = new Regex(@"[ ]{2,}", options);

            string input = "1 2 3 4   5";
            string result = regex.Replace(input, " ");

            Console.WriteLine(result);
        }
    }
}