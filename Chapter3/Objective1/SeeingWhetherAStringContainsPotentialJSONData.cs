using System.ComponentModel;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-12 Seeing whether a string contains potential JSON data.")]
    internal class SeeingWhetherAStringContainsPotentialJSONData : ISample
    {
        public void Run()
        {
        }

        public static bool IsJson(string input)
        {
            input = input.Trim();
            return input.StartsWith("{") && input.EndsWith("}")
                   || input.StartsWith("[") && input.EndsWith("]");
        }
    }
}