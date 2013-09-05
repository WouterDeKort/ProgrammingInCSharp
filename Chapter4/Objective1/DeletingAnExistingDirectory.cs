using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-3 Deleting an existing directory.")]
    internal class DeletingAnExistingDirectory : ISample
    {
        public void Run()
        {
            if (Directory.Exists(@"C:\Temp\ProgrammingInCSharp\Directory"))
            {
                Directory.Delete(@"C:\Temp\ProgrammingInCSharp\Directory");
            }

            var directoryInfo = new DirectoryInfo(@"C:\Temp\ProgrammingInCSharp\DirectoryInfo");
            if (directoryInfo.Exists)
            {
                directoryInfo.Delete();
            }
        }
    }
}