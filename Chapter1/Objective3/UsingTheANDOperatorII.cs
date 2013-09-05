using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-50 Using the AND operator.")]
    internal class UsingTheANDOperatorII : ISample
    {
        public void Run()
        {
            Process(null);
            Process("value");
        }

        public void Process(string input)
        {
            bool result = (input != null) && (input.StartsWith("v"));
            // Do something with the result
        }
    }
}