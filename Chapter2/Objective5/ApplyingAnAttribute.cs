using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-58 Applying an attribute.")]
    internal class ApplyingAnAttribute : ISample
    {
        public void Run()
        {
        }

        [Serializable]
        private class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}