using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective5
{
    [Description("Listing 1-91 Using a finally block.")]
    internal class UsingAFinallyBlock : ISample
    {
        public void Run()
        {
            Console.WriteLine("Please enter a number:");
            string s = Console.ReadLine();

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
            finally
            {
                Console.WriteLine("Program complete.");
            }
        }
    }
}