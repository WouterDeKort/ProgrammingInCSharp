using System;
using System.ComponentModel;
using System.Security.Cryptography;
using Startup;

namespace Chapter3.Objective2
{
    [Description("Listing 3-18 Exporting a public key.")]
    internal class ExportingAPublicKey : ISample
    {
        public void Run()
        {
            var rsa = new RSACryptoServiceProvider();
            string publicKeyXML = rsa.ToXmlString(false);
            string privateKeyXML = rsa.ToXmlString(true);

            Console.WriteLine(publicKeyXML);
            Console.WriteLine(privateKeyXML);
        }
    }
}