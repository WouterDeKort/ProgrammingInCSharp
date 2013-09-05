using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-9 Moving a file.")]
    internal class MovingAFile : ISample
    {
        public void Run()
        {
            string path = @"c:\temp\test.txt";
            string destPath = @"c:\temp\destTest.txt";

            if (!File.Exists((path)))
                File.CreateText(path);
            if (File.Exists(destPath))
                File.Delete(destPath);

            File.CreateText(path).Close();
            File.Move(path, destPath);

            if (!File.Exists((path)))
                File.CreateText(path);
            if (File.Exists(destPath))
                File.Delete(destPath);

            var fileInfo = new FileInfo(path);
            fileInfo.MoveTo(destPath);
        }
    }
}