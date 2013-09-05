using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Startup;

namespace Chapter3.Objective2
{
    [Description("Listing 3-23 Using SHA256Managed to calculate a hash code.")]
    internal class UsingSHA256ManagedToCalculateAHashCode : ISample
    {
        public void Run()
        {
            var byteConverter = new UnicodeEncoding();
            SHA256 sha256 = SHA256.Create();

            string data = "A paragraph of text";
            byte[] hashA = sha256.ComputeHash(byteConverter.GetBytes(data));

            data = "A paragraph of changed text";
            byte[] hashB = sha256.ComputeHash(byteConverter.GetBytes(data));

            data = "A paragraph of text";
            byte[] hashC = sha256.ComputeHash(byteConverter.GetBytes(data));

            Console.WriteLine(hashA.SequenceEqual(hashB));
            Console.WriteLine(hashA.SequenceEqual(hashC));
        }
    }
}