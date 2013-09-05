using System;
using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-21 Using exception handling when opening a file.")]
    internal class UsingExceptionHandlingWhenOpeningAFile : ISample
    {
        public void Run()
        {
            string path = @"C:\temp\test.txt";

            try
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (DirectoryNotFoundException)
            {
            }
            catch (FileNotFoundException)
            {
            }
        }
    }
}