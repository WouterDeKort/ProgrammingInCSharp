using System;
using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective3
{
    [Description("Listing 1-73 The compiler-generated code for a foreach loop.")]
    internal class TheCompilerGeneratedCodeForAForeachLoop : ISample
    {
        public void Run()
        {
            var people = new List<Person>
            {
                new Person {FirstName = "John", LastName = "Doe"},
                new Person {FirstName = "Jane", LastName = "Doe"},
            };

            List<Person>.Enumerator e = people.GetEnumerator();

            try
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;
                }
            }
            finally
            {
                IDisposable d = e;
                if (d != null) d.Dispose();
            }
        }

        private class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}