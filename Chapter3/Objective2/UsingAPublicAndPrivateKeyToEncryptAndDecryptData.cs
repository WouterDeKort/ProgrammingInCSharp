using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;
using Startup;

namespace Chapter3.Objective2
{
    [Description("Listing 3-19 Using a public and private key to encrypt and decrypt data.")]
    internal class UsingAPublicAndPrivateKeyToEncryptAndDecryptData : ISample
    {
        public void Run()
        {
            var _exportKey = new RSACryptoServiceProvider();
            string publicKeyXML = _exportKey.ToXmlString(false);
            string privateKeyXML = _exportKey.ToXmlString(true);

            var ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My Secret Data!");

            byte[] encryptedData;
            using (var RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(publicKeyXML);
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }

            byte[] decryptedData;
            using (var RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(privateKeyXML);
                decryptedData = RSA.Decrypt(encryptedData, false);
            }

            string decryptedString = ByteConverter.GetString(decryptedData);
            Console.WriteLine(decryptedString); // Displays: My Secret Data!        }
        }
    }
}