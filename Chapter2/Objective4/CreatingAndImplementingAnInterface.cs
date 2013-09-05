using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-41 Creating and implementing an interface.")]
    internal class CreatingAndImplementingAnInterface : ISample
    {
        public void Run()
        {
        }

        private class ExampleImplementation : IExample
        {
            public string GetResult()
            {
                return "result";
            }

            public int Value { get; set; }

            public event EventHandler ResultRetrieved;

            public int this[string index]
            {
                get { return 42; }
                set { }
            }

            public event EventHandler CalculationPerformed;
        }

        private interface IExample
        {
            int Value { get; set; }
            int this[string index] { get; set; }
            string GetResult();
            event EventHandler ResultRetrieved;
        }
    }
}