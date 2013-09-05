using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-72 Changing items in a foreach.")]
    internal class ChangingItemsInAForeach : ISample
    {
        public void Run()
        {
            var people = new List<Person>
            {
                new Person {FirstName = "John", LastName = "Doe"},
                new Person {FirstName = "Jane", LastName = "Doe"},
            };

            foreach (Person p in people)
            {
                p.LastName = "Changed"; // This is allowed
                // p = new Person(); // This gives a compile error
            }
        }

        private class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}