using System;
using System.ComponentModel;
using System.Diagnostics;
using Startup;

namespace Chapter3.Objective5
{
    [Description("Listing 3-51 Using EntryWritten.")]
    internal class UsingEntryWritten : ISample
    {
        public void Run()
        {
            var applicationLog = new EventLog("Application", ".", "testEventLogEvent");
            applicationLog.EntryWritten += (sender, e) => { Console.WriteLine(e.Entry.Message); };
            applicationLog.EnableRaisingEvents = true;
            applicationLog.WriteEntry("Test message", EventLogEntryType.Information);

            Console.ReadKey();
        }
    }
}