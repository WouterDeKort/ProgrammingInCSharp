using System.ComponentModel;
using System.Diagnostics;
using Startup;

namespace Chapter3.Objective4
{
    [Description("Listing 3-43 Applying the DebuggerDisplayAttribute.")]
    internal class ApplyingTheDebuggerDisplayAttribute : ISample
    {
        public void Run()
        {
        }

        [DebuggerDisplay("Name = {FirstName} {LastName")]
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}