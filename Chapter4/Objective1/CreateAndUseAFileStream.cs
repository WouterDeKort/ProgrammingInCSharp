using System.ComponentModel;
using System.IO;
using System.Text;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-14 Create and use a FileStream.")]
    internal class CreateAndUseAFileStream : ISample
    {
        public void Run()
        {
            string path = @"c:\temp\test.dat";

            using (FileStream fileStream = File.Create(path))
            {
                string myValue = "MyValue";
                byte[] data = Encoding.UTF8.GetBytes(myValue);
                fileStream.Write(data, 0, data.Length);
            }
        }
    }
}