using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-49 Using the AND operator.")]
    internal class UsingTtheANDOperator : ISample
    {
        public void Run()
        {
            int value = 42;
            bool result = (0 < value) && (value < 100);

            Console.WriteLine(result);
        }
    }
}