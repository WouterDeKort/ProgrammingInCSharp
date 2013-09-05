using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Startup;

namespace Chapter4.Objective5
{
    [Description("Listing 4-90 Inheriting from List<T> to form a custom collection.")]
    internal class InheritingFromListTToFormACustomCollection : ISample
    {
        public void Run()
        {
        }

        public class PeopleCollection : List<Person>
        {
            public void RemoveByAge(int age)
            {
                for (int index = Count - 1; index >= 0; index--)
                {
                    if (this[index].Age == age)
                    {
                        RemoveAt(index);
                    }
                }
            }

            public override string ToString()
            {
                var sb = new StringBuilder();
                foreach (Person p in this)
                {
                    sb.AppendFormat("{0} {1} is {2}", p.FirstName, p.LastName, p.Age);
                }
                return sb.ToString();
            }
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
    }
}