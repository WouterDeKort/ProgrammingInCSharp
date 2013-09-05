using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-96 Overriding ToString")]
    internal class OverridingToString : ISample
    {
        public void Run()
        {
            var p = new Person("John", "Doe");
            Console.WriteLine(p);
        }

        private class Person
        {
            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return FirstName + LastName;
            }
        }
    }
}