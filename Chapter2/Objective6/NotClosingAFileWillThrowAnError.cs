using System;
using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter2.Objective6
{
    [Description("Listing 2-80 Not closing a file will throw an error.")]
    internal class NotClosingAFileWillThrowAnError : ISample

    {
        public void Run()
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");

            try
            {
                File.Delete("temp.dat"); // Throws an IOException because the file is already open.        
            }
            catch (IOException)
            {
                Console.WriteLine("Exception thrown");
            }
        }
    }
}