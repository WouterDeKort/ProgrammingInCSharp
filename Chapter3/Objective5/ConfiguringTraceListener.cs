using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Startup;

namespace Chapter3.Objective5
{
    [Description("Listing 3-47 Configuring TraceListener.")]
    internal class ConfiguringTraceListener : ISample
    {
        public void Run()
        {
            Stream outputFile = File.Create("tracefile.txt");
            var textListener =
                new TextWriterTraceListener(outputFile);

            var traceSource = new TraceSource("myTraceSource",
                SourceLevels.All);

            traceSource.Listeners.Clear();
            traceSource.Listeners.Add(textListener);

            traceSource.TraceInformation("Trace output");

            traceSource.Flush();
            traceSource.Close();
        }
    }
}