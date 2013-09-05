using System.ComponentModel;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-37 A simple Person class.")]
    internal class ASimplePersonClass : ISample
    {
        public void Run()
        {
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}