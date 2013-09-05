using System.ComponentModel;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-47 Overriding a virtual method.")]
    internal class OverridingAVirtualMethod : ISample
    {
        public void Run()
        {
        }

        private class Base
        {
            protected virtual void Execute()
            {
            }
        }

        private class Derived : Base
        {
            protected override void Execute()
            {
                Log("Before executing");
                base.Execute();
                Log("After executing");
            }

            private void Log(string message)
            {
                /* some logging code */
            }
        }
    }
}