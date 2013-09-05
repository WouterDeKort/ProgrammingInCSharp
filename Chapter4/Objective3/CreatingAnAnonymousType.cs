using System;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-53 Creating an anonymous type.")]
    internal class CreatingAnAnonymousType : ISample
    {
        public void Run()
        {
            var person = new
            {
                FirstName = "John",
                LastName = "Doe"
            };

            Console.WriteLine(person.GetType().Name);
        }
    }
}