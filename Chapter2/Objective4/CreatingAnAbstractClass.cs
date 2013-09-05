using System.ComponentModel;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-49 Creating an abstract class.")]
    internal class CreatingAnAbstractClass : ISample
    {
        public void Run()
        {
        }

        private abstract class Base
        {
            public virtual void MethodWithImplementation()
            {
/*Method with implementation*/
            }

            public abstract void AbstractMethod();
        }

        private class Derived : Base
        {
            public override void AbstractMethod()
            {
            }
        }
    }
}