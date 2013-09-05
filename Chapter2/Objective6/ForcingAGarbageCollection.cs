using System;
using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter2.Objective6
{
    [Description("Listing 2-81 Forcing a garbage collection.")]
    internal class ForcingAGarbageCollection : ISample

    {
        public void Run()
        {
            string randomFileName = string.Format("temp{0}.dat", Guid.NewGuid());
            StreamWriter stream = File.CreateText(randomFileName);
            stream.Write("some data");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.Delete("temp.dat");
        }
    }
}