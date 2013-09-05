using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-15 Using File.CreateText with a StreamWriter.")]
    internal class UsingFileCreateTextWithAStreamWriter : ISample
    {
        public void Run()
        {
            string path = @"c:\temp\test.dat";

            using (StreamWriter streamWriter = File.CreateText(path))
            {
                string myValue = "MyValue";
                streamWriter.Write(myValue);
            }
        }
    }
}