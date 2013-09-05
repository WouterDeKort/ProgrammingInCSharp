using System;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-11 Don’t manually concatenate strings to form a file path.")]
    internal class DontManuallyConcatenateStringsToFormAFilePath : ISample
    {
        public void Run()
        {
            string folder = @"C:\temp";
            string fileName = "test.dat";

            string fullPath = folder + fileName;
            Console.WriteLine(fullPath);
        }
    }
}