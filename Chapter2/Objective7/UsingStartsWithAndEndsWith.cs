using System.ComponentModel;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-92  Using StartsWith and EndsWith.")]
    internal class UsingStartsWithAndEndsWith : ISample
    {
        public void Run()
        {
            string value = "<mycustominput>";
            if (value.StartsWith("<"))
            {
            }
            if (value.EndsWith(">"))
            {
            }
        }
    }
}