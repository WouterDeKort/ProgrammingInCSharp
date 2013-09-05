using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective3
{
    [Description("Listing 2-37 Creating a property.")]
    internal class CreatingAProperty : ISample
    {
        public void Run()
        {
        }

        private class Person
        {
            private string _firstName;

            public string FirstName
            {
                get { return _firstName; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException();
                    _firstName = value;
                }
            }
        }
    }
}