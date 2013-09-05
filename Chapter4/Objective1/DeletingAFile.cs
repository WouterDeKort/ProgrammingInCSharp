using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-8 Deleting a file.")]
    internal class DeletingAFile : ISample
    {
        public void Run()
        {
            string path = @"c:\temp\test.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            var fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
        }
    }
}