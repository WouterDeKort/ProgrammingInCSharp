using System;
using System.ComponentModel;
using System.Diagnostics;
using Startup;

namespace Chapter3.Objective5
{
    [Description("Listing 3-50 Reading data from the event log.")]
    internal class ReadingDataFromTheEventLog : ISample
    {
        public void Run()
        {
            var log = new EventLog("MyNewLog");

            Console.WriteLine("Total entries: " + log.Entries.Count);
            EventLogEntry last = log.Entries[log.Entries.Count - 1];
            Console.WriteLine("Index:   " + last.Index);
            Console.WriteLine("Source:  " + last.Source);
            Console.WriteLine("Type:    " + last.EntryType);
            Console.WriteLine("Time:    " + last.TimeWritten);
            Console.WriteLine("Message: " + last.Message);
        }
    }
}