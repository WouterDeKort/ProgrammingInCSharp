using System.ComponentModel;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-49 Using an object initializer.")]
    internal class UsingAnObjectInitializer : ISample
    {
        public void Run()
        {
            // Create and initialize a new object in one step
            var p = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}