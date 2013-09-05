using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-18 Compressing data with a GZipStream.")]
    internal class CompressingDataWithAGZipStream : ISample
    {
        public void Run()
        {
            string folder = @"c:\temp";
            string uncompressedFilePath = Path.Combine(folder, "uncompressed.dat");
            string compressedFilePath = Path.Combine(folder, "compressed.gz");
            byte[] dataToCompress = Enumerable.Repeat((byte) 'a', 1024*1024).ToArray();

            using (FileStream uncompressedFileStream = File.Create(uncompressedFilePath))
            {
                uncompressedFileStream.Write(dataToCompress, 0, dataToCompress.Length);
            }
            using (FileStream compressedFileStream = File.Create(compressedFilePath))
            {
                using (var compressionStream = new GZipStream(
                    compressedFileStream, CompressionMode.Compress))
                {
                    compressionStream.Write(dataToCompress, 0, dataToCompress.Length);
                }
            }

            var uncompressedFile = new FileInfo(uncompressedFilePath);
            var compressedFile = new FileInfo(compressedFilePath);

            Console.WriteLine(uncompressedFile.Length);
            Console.WriteLine(compressedFile.Length);
        }
    }
}