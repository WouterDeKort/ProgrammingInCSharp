using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-6 Moving a directory.")]
    internal class MovingADirectory : ISample
    {
        public void Run()
        {
            string destination = @"C:\destination";
            string source = @"C:\source";

            if (Directory.Exists(destination))
                Directory.Delete(destination);

            if (!Directory.Exists(source))
                Directory.CreateDirectory(source);

            Directory.Move(source, destination);

            if (Directory.Exists(destination))
                Directory.Delete(destination);

            if (!Directory.Exists(source))
                Directory.CreateDirectory(source);

            var directoryInfo = new DirectoryInfo(source);
            directoryInfo.MoveTo(destination);
        }
    }
}