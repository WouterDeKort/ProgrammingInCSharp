using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-17 Overriding a virtual method.")]
    internal class OverridingAVirtualMethod : ISample
    {
        public void Run()
        {
        }

        private class Base
        {
            public virtual int MyMethod()
            {
                return 42;
            }
        }

        private class Derived : Base
        {
            public override int MyMethod()
            {
                return base.MyMethod()*2;
            }
        }
    }
}