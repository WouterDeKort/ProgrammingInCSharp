using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-23 Writing asynchronously to a file.")]
    internal class WritingAsynchronouslyToAFile : ISample
    {
        public void Run()
        {
        }

        public async Task CreateAndWriteAsyncToFile()
        {
            using (var stream = new FileStream("test.dat", FileMode.Create,
                FileAccess.Write, FileShare.None, 4096, true))
            {
                var data = new byte[100000];
                new Random().NextBytes(data);

                await stream.WriteAsync(data, 0, data.Length);
            }
        }
    }
}