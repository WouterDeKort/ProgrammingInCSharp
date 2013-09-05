using System;
using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-7 Listing all the files in a directory.")]
    internal class ListingAllTheFilesInADirectory : ISample
    {
        public void Run()
        {
            foreach (string file in Directory.GetFiles(@"C:\Windows"))
            {
                Console.WriteLine(file);
            }

            var directoryInfo = new DirectoryInfo(@"C:\Windows");
            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
            {
                Console.WriteLine(fileInfo.FullName);
            }
        }
    }
}