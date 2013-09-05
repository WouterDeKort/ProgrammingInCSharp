using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-61 A complex if statement.")]
    internal class AComplexIfStatement : ISample
    {
        public void Run()
        {
            Check('a');
            Check('z');
        }

        private void Check(char input)
        {
            if (input == 'a'
                || input == 'e'
                || input == 'i'
                || input == 'o'
                || input == 'u')
            {
                Console.WriteLine("Input is a vowel");
            }
            else
            {
                Console.WriteLine("Input is a consonant");
            }
        }
    }
}