using System;
using System.ComponentModel;
using System.Diagnostics;
using Startup;

namespace Chapter3.Objective5
{
    [Description("Listing 3-53 Reading data from a performance counter.")]
    internal class ReadingDataFromAPerformanceCounter : ISample
    {
        public void Run()
        {
            Console.WriteLine("Press escape key to stop");
            using (var pc =
                new PerformanceCounter("Memory", "Available Bytes"))
            {
                string text = "Available memory: ";
                Console.Write(text);
                do
                {
                    while (!Console.KeyAvailable)
                    {
                        Console.Write(pc.RawValue);
                        Console.SetCursorPosition(text.Length, Console.CursorTop);
                    }
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
        }
    }
}