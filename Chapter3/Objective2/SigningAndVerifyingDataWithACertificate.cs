using System;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Startup;

namespace Chapter3.Objective2
{
    [Description("Listing 3-24 Signing and verifying data with a certificate.")]
    internal class SigningAndVerifyingDataWithACertificate : ISample
    {
        public void Run()
        {
        }

        public static void SignAndVerify()
        {
            string textToSign = "Test paragraph";
            byte[] signature = Sign(textToSign, "cn=WouterDeKort");
            // Uncomment this line to make the verification step fail
            // signature[0] = 0;
            Console.WriteLine(Verify(textToSign, signature));
        }

        private static byte[] Sign(string text, string certSubject)
        {
            X509Certificate2 cert = GetCertificate();
            var csp = (RSACryptoServiceProvider) cert.PrivateKey;
            byte[] hash = HashData(text);
            return csp.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));
        }

        private static bool Verify(string text, byte[] signature)
        {
            X509Certificate2 cert = GetCertificate();
            var csp = (RSACryptoServiceProvider) cert.PublicKey.Key;
            byte[] hash = HashData(text);
            return csp.VerifyHash(hash,
                CryptoConfig.MapNameToOID("SHA1"),
                signature);
        }

        private static byte[] HashData(string text)
        {
            HashAlgorithm hashAlgorithm = new SHA1Managed();
            var encoding = new UnicodeEncoding();
            byte[] data = encoding.GetBytes(text);
            byte[] hash = hashAlgorithm.ComputeHash(data);
            return hash;
        }

        private static X509Certificate2 GetCertificate()
        {
            var my = new X509Store("testCertStore",
                StoreLocation.CurrentUser);
            my.Open(OpenFlags.ReadOnly);

            X509Certificate2 certificate = my.Certificates[0];

            return certificate;
        }
    }
}