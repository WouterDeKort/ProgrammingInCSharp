using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective5
{
    [Description("Listing 1-90 Catching different exception types.")]
    internal class CatchingDifferentExceptionTypes : ISample
    {
        public void Run()
        {
            string s = "1";

            try
            {
                int i = int.Parse(s);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You need to enter a value");
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid number. Please try again", s);
            }
        }
    }
}