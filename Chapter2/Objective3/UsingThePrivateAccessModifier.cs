using System.ComponentModel;
using Startup;

namespace Chapter2.Objective3
{
    [Description("Listing 2-32 Using the private access modifier.")]
    internal class UsingThePrivateAccessModifier : ISample
    {
        public void Run()
        {
        }

        public class Accessibility
        {
            public string MyProperty { get; set; }
        }
    }
}