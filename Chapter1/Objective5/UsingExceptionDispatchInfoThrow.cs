using System;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using Startup;

namespace Chapter1.Objective5
{
    [Description("Listing 1-97 Using ExceptionDispatchInfo.Throw.")]
    internal class UsingExceptionDispatchInfoThrow : ISample
    {
        public void Run()
        {
            ExceptionDispatchInfo possibleException = null;

            try
            {
                Console.WriteLine("Enter a number:");
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if (possibleException != null)
            {
                possibleException.Throw();
            }
        }
    }
}