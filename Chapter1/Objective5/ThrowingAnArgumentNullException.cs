using System;
using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter1.Objective5
{
    [Description("Listing 1-94  Throwing an ArgumentNullException.")]
    internal class ThrowingAnArgumentNullException : ISample
    {
        public void Run()
        {
        }

        public static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentNullException("fileName", "Filename is required");

            return File.ReadAllText(fileName);
        }
    }
}