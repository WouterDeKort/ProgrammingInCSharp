using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-50 Using a collection initializer")]
    internal class UsingACollectionInitializer : ISample
    {
        public void Run()
        {
            var people = new List<Person>
            {
                new Person
                {
                    FirstName = "John",
                    LastName = "Doe"
                },
                new Person
                {
                    FirstName = "Jane",
                    LastName = "Doe"
                }
            };
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}