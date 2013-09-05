using System.ComponentModel;
using Startup;

namespace Chapter2.Objective2
{
    [Description("Listing 2-20 Implicitly converting an integer to a double.")]
    internal class ImplicitlyConvertingAnIntegerToADouble : ISample
    {
        public void Run()
        {
            int i = 42;
            double d = i;
        }
    }
}