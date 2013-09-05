using System;
using System.ComponentModel;
using System.Diagnostics;
using Startup;

namespace Chapter3.Objective5
{
    [Description("Listing 3-49 Writing data to the event log.")]
    internal class WritingDataToTheEventLog : ISample
    {
        public void Run()
        {
            Console.WriteLine("Make sure that you run Visual Studio as administrator");

            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource("MySource", "MyNewLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Please restart application");
                Console.ReadKey();
                return;
            }

            var myLog = new EventLog();
            myLog.Source = "MySource";
            myLog.WriteEntry("Log event!");
        }
    }
}