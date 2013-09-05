using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-56 Implementing IEnumerable<T> on a custom type.")]
    internal class ImplementingIEnumerableOfTOnACustomType : ISample
    {
        public void Run()
        {
        }

        private class People : IEnumerable<Person>
        {
            private readonly Person[] people;

            public People(Person[] people)
            {
                this.people = people;
            }

            public IEnumerator<Person> GetEnumerator()
            {
                for (int index = 0; index < people.Length; index++)
                {
                    yield return people[index];
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        private class Person
        {
            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return FirstName + " " + LastName;
            }
        }
    }
}