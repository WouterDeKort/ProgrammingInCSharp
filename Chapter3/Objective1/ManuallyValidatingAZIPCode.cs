using System.ComponentModel;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-9 Manually validating a ZIP Code.")]
    internal class ManuallyValidatingAZIPCode : ISample
    {
        public void Run()
        {
        }

        private static bool ValidateZipCode(string zipCode)
        {
            // Valid zipcodes: 1234AB | 1234 AB | 1001 AB

            if (zipCode.Length < 6) return false;

            string numberPart = zipCode.Substring(0, 4);
            int number;
            if (!int.TryParse(numberPart, out number)) return false;

            string characterPart = zipCode.Substring(4);

            if (numberPart.StartsWith("0")) return false;
            if (characterPart.Trim().Length < 2) return false;
            if (characterPart.Length == 3 && characterPart.Trim().Length != 2)
                return false;

            return true;
        }
    }
}