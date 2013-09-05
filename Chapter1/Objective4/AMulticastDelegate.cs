using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-76 A multicast delegate.")]
    internal class AMulticastDelegate : ISample
    {
        public delegate void Del();

        public void Run()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();
        }

        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }
    }
}