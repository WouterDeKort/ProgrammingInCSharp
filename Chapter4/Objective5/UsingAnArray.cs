using System;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective5
{
    [Description("Listing 4-80 Using an array.")]
    internal class UsingAnArray : ISample
    {
        public void Run()
        {
            var arrayOfInt = new int[10];

            for (int x = 0; x < arrayOfInt.Length; x++)
            {
                arrayOfInt[x] = x;
            }

            foreach (int i in arrayOfInt)
            {
                Console.Write(i); 
            }
        }
    }
}