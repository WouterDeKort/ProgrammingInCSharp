using System.ComponentModel;
using System.Diagnostics;
using Startup;

namespace Chapter3.Objective5
{
    [Description("Listing 3-46 Using the TraceSource class.")]
    internal class UsingTheTraceSourceClass : ISample
    {
        public void Run()
        {
            var traceSource = new TraceSource("myTraceSource",
                SourceLevels.All);

            traceSource.TraceInformation("Tracing application..");
            traceSource.TraceEvent(TraceEventType.Critical, 0, "Critical trace");
            traceSource.TraceData(TraceEventType.Information, 1,
                new object[] {"a", "b", "c"});

            traceSource.Flush();
            traceSource.Close();
        }
    }
}