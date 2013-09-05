using System.ComponentModel;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-86 Creating a large number of strings.")]
    internal class CreatingALargeNumberOfStrings : ISample
    {
        public void Run()
        {
            string s = string.Empty;

            for (int i = 0; i < 10000; i++)
            {
                s += "x";
            }
        }
    }
}