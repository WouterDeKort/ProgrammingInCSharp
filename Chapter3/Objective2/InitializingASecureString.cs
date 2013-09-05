using System;
using System.ComponentModel;
using System.Security;
using Startup;

namespace Chapter3.Objective2
{
    [Description("Listing 3-27 Initializing a SecureString.")]
    internal class InitializingASecureString : ISample
    {
        public void Run()
        {
            using (var ss = new SecureString())
            {
                Console.Write("Please enter password: ");
                while (true)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter) break;

                    ss.AppendChar(cki.KeyChar);
                    Console.Write("*");
                }
                ss.MakeReadOnly();
            }
        }
    }
}