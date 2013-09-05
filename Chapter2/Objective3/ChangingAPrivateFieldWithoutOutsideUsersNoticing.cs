using System.ComponentModel;
using Startup;

namespace Chapter2.Objective3
{
    [Description("Listing 2-33 Changing a private field without outside users noticing.")]
    internal class ChangingAPrivateFieldWithoutOutsideUsersNoticing : ISample
    {
        public void Run()
        {
        }

        public class Accessibility
        {
            // initialization code and error checking omitted
            private string[] _myField;

            public string MyProperty
            {
                get { return _myField[0]; }
                set { _myField[0] = value; }
            }
        }
    }
}