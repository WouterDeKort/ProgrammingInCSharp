using System.ComponentModel;
using Startup;

namespace Chapter4.Objective5
{
    [Description("Listing 4-91 Using a custom collection.")]
    internal class UsingACustomCollection : ISample
    {
        public void Run()
        {
            var p1 = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 42
            };
            var p2 = new Person
            {
                FirstName = "Jane",
                LastName = "Doe",
                Age = 21
            };
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
    }
}