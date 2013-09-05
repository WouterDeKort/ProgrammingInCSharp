using System;
using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-20 Depending on File.Exists when reading file content.")]
    internal class DependingOnFileExistsWhenReadingFileContent : ISample
    {
        public void Run()
        {
            Console.WriteLine(ReadAllText());
        }

        private static string ReadAllText()
        {
            string path = @"C:\temp\test.txt";

            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return string.Empty;
        }
    }
}