using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-62 A switch statement")]
    internal class ASwitchStatement : ISample
    {
        public void Run()
        {
            CheckWithSwitch('a');
            CheckWithSwitch('z');
        }

        private void CheckWithSwitch(char input)
        {
            switch (input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                {
                    Console.WriteLine("Input is a vowel");
                    break;
                }
                case 'y':
                {
                    Console.WriteLine("Input is sometimes a vowel.");
                    break;
                }
                default:
                {
                    Console.WriteLine("Input is a consonant");
                    break;
                }
            }
        }
    }
}