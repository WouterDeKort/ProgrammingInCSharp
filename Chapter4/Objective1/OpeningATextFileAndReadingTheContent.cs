using System;
using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-17 Opening a TextFile and reading the content.")]
    internal class OpeningATextFileAndReadingTheContent : ISample
    {
        public void Run()

        {
            string path = @"c:\temp\test.dat";
            using (StreamReader streamWriter = File.OpenText(path))
            {
                Console.WriteLine(streamWriter.ReadLine()); 
            }
        }
    }
}