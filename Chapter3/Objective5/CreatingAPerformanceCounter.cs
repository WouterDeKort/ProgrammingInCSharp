using System;
using System.ComponentModel;
using System.Diagnostics;
using Startup;

namespace Chapter3.Objective5
{
    [Description("Listing 3-54 Creating a performance counter.")]
    internal class CreatingAPerformanceCounter : ISample
    {
        public void Run()
        {
            if (CreatePerformanceCounters())
            {
                Console.WriteLine("Created performance counters");
                Console.WriteLine("Please restart application");
                Console.ReadKey();
                return;
            }
            var totalOperationsCounter = new PerformanceCounter(
                "MyCategory",
                "# operations executed",
                "",
                false);
            var operationsPerSecondCounter = new PerformanceCounter(
                "MyCategory",
                "# operations / sec",
                "",
                false);

            totalOperationsCounter.Increment();
            operationsPerSecondCounter.Increment();
        }

        private static bool CreatePerformanceCounters()
        {
            if (!PerformanceCounterCategory.Exists("MyCategory"))
            {
                var counters =
                    new CounterCreationDataCollection
                    {
                        new CounterCreationData(
                            "# operations executed",
                            "Total number of operations executed",
                            PerformanceCounterType.NumberOfItems32),
                        new CounterCreationData(
                            "# operations / sec",
                            "Number of operations executed per second",
                            PerformanceCounterType.RateOfCountsPerSecond32)
                    };

                PerformanceCounterCategory.Create("MyCategory",
                    "Sample category for Codeproject", counters);

                return true;
            }

            return false;
        }
    }
}