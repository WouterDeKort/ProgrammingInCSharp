using System;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-9 Manually validating a ZIP Code.")]
    internal class ManuallyValidatingAZIPCode : ISample
    {
        public void Run()
        {
            ValidateAndDisplay("1234 AB");
            ValidateAndDisplay("1234AB");
            ValidateAndDisplay("1001 AB");
            ValidateAndDisplay("1001 ABC");
            ValidateAndDisplay("101 BC");
            ValidateAndDisplay("1000 A1");

        }

        private static void ValidateAndDisplay(string p)
        {
            Console.WriteLine("{0}:{1}", p, ValidateZipCode(p));
        }

        private static bool ValidateZipCode(string zipCode)
        {
            if (zipCode.Length < 6) return false;

            string numberPart = zipCode.Substring(0, 4);
            if (numberPart.StartsWith("0")) return false;

            int number;
            if (!int.TryParse(numberPart, out number)) return false;

            if (number < 1000) return false;
            if (number > 9999) return false;

            string characterPart = zipCode.Substring(4).Trim();

            if (characterPart.Trim().Length != 2) return false;

            foreach (char c in characterPart)
            {
                if (!char.IsLetter(c)) return false;
            }

            return true;
        }
    }
}