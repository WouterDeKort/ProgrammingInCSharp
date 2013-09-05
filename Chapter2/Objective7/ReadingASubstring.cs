using System.ComponentModel;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-93 Reading a substring.")]
    internal class ReadingASubstring : ISample
    {
        public void Run()
        {
            string value = "My Sample Value";
            string subString = value.Substring(3, 6);
        }
    }
}