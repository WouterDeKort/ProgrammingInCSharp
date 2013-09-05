using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-4 Creating a method.")]
    internal class CreatingAMethod : ISample
    {
        public void Run()
        {
            var c = new Calculator();
            c.Add(42, 2);
        }

        private class Calculator
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
        }
    }
}