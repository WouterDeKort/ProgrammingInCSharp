using System.ComponentModel;
using Startup;

namespace Chapter2.Objective2
{
    [Description("Listing 2-19 Boxing an integer value.")]
    internal class BoxingAnIntegerValue : ISample
    {
        public void Run()
        {
            int i = 42;
            object o = i;
            var x = (int) o;
        }
    }
}