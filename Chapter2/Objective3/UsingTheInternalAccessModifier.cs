using System.ComponentModel;
using Startup;

namespace Chapter2.Objective3
{
    [Description("Listing 2-35 Using the internal access modifier.")]
    internal class UsingTheInternalAccessModifier : ISample
    {
        public void Run()
        {
        }

        internal class MyInternalClass
        {
            public void MyMethod()
            {
            }
        }
    }
}