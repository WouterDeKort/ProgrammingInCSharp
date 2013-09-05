using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter2.Objective6
{
    [Description("Listing 2-83 Calling Dispose to free unmanaged resources.")]
    internal class CallingDisposeToFreeUnmanagedResources : ISample
    {
        public void Run()
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            stream.Dispose();
            File.Delete("temp.dat");
        }
    }
}