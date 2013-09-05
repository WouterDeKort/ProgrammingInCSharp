using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-19 Using a BufferedStream.")]
    internal class UsingABufferedStream : ISample
    {
        public void Run()
        {
            string path = @"c:\temp\bufferedStream.txt";

            using (FileStream fileStream = File.Create(path))
            {
                using (var bufferedStream = new BufferedStream(fileStream))
                {
                    using (var streamWriter = new StreamWriter(bufferedStream))
                    {
                        streamWriter.WriteLine("A line of text.");
                    }
                }
            }
        }
    }
}