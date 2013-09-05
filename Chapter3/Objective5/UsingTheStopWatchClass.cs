using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using Startup;

namespace Chapter3.Objective5
{
    [Description("Listing 3-52 Using the StopWatch class.")]
    internal class UsingTheStopWatchClass : ISample
    {
        private const int numberOfIterations = 100000;

        public void Run()
        {
            var sw = new Stopwatch();
            sw.Start();
            Algorithm1();
            sw.Stop();

            Console.WriteLine(sw.Elapsed);

            sw.Reset();
            sw.Start();
            Algorithm2();
            sw.Stop();

            Console.WriteLine(sw.Elapsed);
            Console.WriteLine("Ready...");
            Console.ReadLine();
        }

        private static void Algorithm2()
        {
            string result = "";

            for (int x = 0; x < numberOfIterations; x++)
            {
                result += 'a';
            }
        }

        private static void Algorithm1()
        {
            var sb = new StringBuilder();
            for (int x = 0; x < numberOfIterations; x++)
            {
                sb.Append('a');
            }

            string result = sb.ToString();
        }
    }
}