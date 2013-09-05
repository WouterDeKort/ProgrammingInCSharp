using System.ComponentModel;
using System.Text;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-88  Using a StringBuilder in a loop.")]
    internal class UsingAStringBuilderInALoop : ISample
    {
        public void Run()
        {
            var sb = new StringBuilder(string.Empty);

            for (int i = 0; i < 10000; i++)
            {
                sb.Append("x");
            }
        }
    }
}