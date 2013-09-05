using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-48 Hiding a method with the new keyword.")]
    internal class HidingAMethodWithTheNewKeyword : ISample
    {
        public void Run()
        {
            var b = new Base();
            b.Execute();
            b = new Derived();
            b.Execute();
        }

        private class Base
        {
            public void Execute()
            {
                Console.WriteLine("Base.Execute");
            }
        }

        private class Derived : Base
        {
            public new void Execute()
            {
                Console.WriteLine("Derived.Execute");
            }
        }
    }
}