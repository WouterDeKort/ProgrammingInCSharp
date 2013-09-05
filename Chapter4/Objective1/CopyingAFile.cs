using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-10 Copying a file.")]
    internal class CopyingAFile : ISample
    {
        public void Run()
        {
            string path = @"c:\temp\test.txt";
            string destPath = @"c:\temp\destTest.txt";

            File.CreateText(path).Close();
            File.Copy(path, destPath);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(destPath);
        }
    }
}