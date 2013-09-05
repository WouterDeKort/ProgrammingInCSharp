using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-12 Chaining constructors.")]
    internal class ChainingConstructors : ISample
    {
        public void Run()
        {
        }

        private class ConstructorChaining
        {
            private int _p;

            public ConstructorChaining() : this(3)
            {
            }

            public ConstructorChaining(int p)
            {
                _p = p;
            }
        }
    }
}