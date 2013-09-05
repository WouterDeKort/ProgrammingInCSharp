using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-12 Using Path.Combine.")]
    internal class UsingPathCombine : ISample
    {
        public void Run()
        {
            string folder = @"C:\temp";
            string fileName = "test.dat";

            string fullPath = Path.Combine(folder, fileName); // Results in C:\\temp\\test.dat        }
        }
    }
}