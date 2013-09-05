using System.ComponentModel;
using Startup;

namespace Chapter2.Objective2
{
    [Description("Listing 2-22 Casting a double to an int.")]
    internal class CastingADoubleToAnInt : ISample
    {
        public void Run()
        {
            double x = 1234.7;
            int a;
            // Cast double to int 
            a = (int) x; // a = 1234
        }
    }
}