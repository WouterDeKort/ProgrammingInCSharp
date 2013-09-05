using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using Startup;

namespace Chapter3.Objective2
{
    [Description("Listing 3-28 Getting the value of a SecureString.")]
    internal class GettingTheValueOfASecureString : ISample
    {
        public void Run()
        {
        }

        public static void ConvertToUnsecureString(SecureString securePassword)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                Console.WriteLine(Marshal.PtrToStringUni(unmanagedString));
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}