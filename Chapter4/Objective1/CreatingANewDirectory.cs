using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-2 Creating a new directory.")]
    internal class CreatingANewDirectory : ISample
    {
        public void Run()
        {
            DirectoryInfo directory = Directory.CreateDirectory(@"C:\Temp\ProgrammingInCSharp\Directory");

            var directoryInfo = new DirectoryInfo(@"C:\Temp\ProgrammingInCSharp\DirectoryInfo");
            directoryInfo.Create();
        }
    }
}