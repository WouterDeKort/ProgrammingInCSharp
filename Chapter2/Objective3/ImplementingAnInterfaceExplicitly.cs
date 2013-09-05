using System.ComponentModel;
using Startup;

namespace Chapter2.Objective3
{
    [Description("Listing 2-39 Implementing an interface explicitly.")]
    internal class ImplementingAnInterfaceExplicitly : ISample
    {
        public void Run()
        {
        }

        private interface IInterfaceA
        {
            void MyMethod();
        }

        private class Implementation : IInterfaceA
        {
            void IInterfaceA.MyMethod()
            {
            }
        }
    }
}