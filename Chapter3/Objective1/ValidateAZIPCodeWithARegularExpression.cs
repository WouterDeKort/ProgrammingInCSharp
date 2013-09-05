using System.ComponentModel;
using System.Text.RegularExpressions;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-10 Validate a ZIP Code with a regular expression.")]
    internal class ValidateAZIPCodeWithARegularExpression : ISample
    {
        public void Run()
        {
        }

        private static bool ValidateZipCodeRegEx(string zipCode)
        {
            Match match = Regex.Match(zipCode, @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$",
                RegexOptions.IgnoreCase);
            return match.Success;
        }
    }
}