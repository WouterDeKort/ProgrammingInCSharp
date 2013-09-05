using System;
using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-13 Using other Path methods to parse a path.")]
    internal class UsingOtherPathMethodsToParseAPath : ISample
    {
        public void Run()
        {
            string path = @"C:\temp\subdir\file.txt";

            Console.WriteLine(Path.GetDirectoryName(path)); 
            Console.WriteLine(Path.GetExtension(path)); 
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetPathRoot(path));
        }
    }
}