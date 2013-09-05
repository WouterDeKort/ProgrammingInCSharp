using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-91 Using IndexOf and LastIndexOf.")]
    internal class UsingIndexOfAndLastIndexOf : ISample
    {
        public void Run()
        {
            string value = "My Sample Value";
            int indexOfp = value.IndexOf('p');
            int lastIndexOfm = value.LastIndexOf('m');

            Console.WriteLine(indexOfp);
            Console.WriteLine(lastIndexOfm);
        }
    }
}