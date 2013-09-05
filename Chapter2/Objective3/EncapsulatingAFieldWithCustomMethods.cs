using System.ComponentModel;
using Startup;

namespace Chapter2.Objective3
{
    [Description("Listing 2-36 Encapsulating a field with custom methods.")]
    internal class EncapsulatingAFieldWithCustomMethods : ISample
    {
        private int _field;

        public void Run()
        {
        }

        public void SetValue(int value)
        {
            _field = value;
        }

        public int GetValue()
        {
            return _field;
        }
    }
}