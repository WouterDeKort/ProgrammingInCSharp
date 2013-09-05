using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using Startup;

namespace Chapter3.Objective2
{
    [Description("Listing 3-20  Using a key container for storing an asymmetric key.")]
    internal class UsingAKeyContainerForStoringAnAsymmetricKey : ISample
    {
        public void Run()
        {
            var byteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = byteConverter.GetBytes("My Secret Data!");

            string containerName = "SecretContainer";
            var csp = new CspParameters {KeyContainerName = containerName};
            byte[] encryptedData;
            using (var RSA = new RSACryptoServiceProvider(csp))
            {
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }
        }
    }
}