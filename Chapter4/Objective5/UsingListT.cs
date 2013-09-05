using System;
using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective5
{
    [Description("Listing 4-84 Using List<T>.")]
    internal class UsingListT : ISample
    {
        public void Run()
        {
            var listOfStrings =
                new List<string> {"A", "B", "C", "D", "E"};

            for (int x = 0; x < listOfStrings.Count; x++)
                Console.Write(listOfStrings[x]); 

            listOfStrings.Remove("A");

            Console.WriteLine(listOfStrings[0]); 

            listOfStrings.Add("F");

            Console.WriteLine(listOfStrings.Count); 

            bool hasC = listOfStrings.Contains("C");

            Console.WriteLine(hasC); 
        }
    }
}