using System.ComponentModel;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-48  Creating and initializing an object.")]
    internal class CreatingAndInitializingAnObject : ISample
    {
        public void Run()
        {
            // Create and initialize a new object
            var p = new Person();
            p.FirstName = "John";
            p.LastName = "Doe";
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}