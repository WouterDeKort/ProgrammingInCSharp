using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-56 Using multiple if/else statements.")]
    internal class UsingMultipleIfElseStatements : ISample
    {
        public void Run()
        {
            bool b = false;
            bool c = true;

            if (b)
            {
                Console.WriteLine("b is true");
            }
            else if (c)
            {
                Console.WriteLine("c is true");
            }
            else
            {
                Console.WriteLine("b and c are false");
            }
        }
    }
}