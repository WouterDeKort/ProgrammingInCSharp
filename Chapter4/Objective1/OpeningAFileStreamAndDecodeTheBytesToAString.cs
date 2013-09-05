using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-16 Opening a FileStream and decode the bytes to a string.")]
    internal class OpeningAFileStreamAndDecodeTheBytesToAString : ISample
    {
        public void Run()
        {
            string path = @"c:\temp\test.dat";

            using (FileStream fileStream = File.OpenRead(path))
            {
                var data = new byte[fileStream.Length];

                for (int index = 0; index < fileStream.Length; index++)
                {
                    data[index] = (byte) fileStream.ReadByte();
                }
                Console.WriteLine(Encoding.UTF8.GetString(data)); 
            }
        }
    }
}