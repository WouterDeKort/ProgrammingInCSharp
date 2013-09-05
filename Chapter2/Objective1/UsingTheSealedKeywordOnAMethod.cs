using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-18 Using the sealed keyword on a method.")]
    internal class UsingTheSealedKeywordOnAMethod : ISample
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
            public override sealed int MyMethod()
            {
                return base.MyMethod()*2;
            }
        }

        private class Derived2 : Derived
        {
            // This line would give a compile error     
            // public override int MyMethod() { return 1;} 
        }
    }
}