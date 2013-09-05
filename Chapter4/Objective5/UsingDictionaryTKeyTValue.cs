using System;
using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective5
{
    [Description("Listing 4-85 Using Dictionary<TKey, TValue>.")]
    internal class UsingDictionaryTKeyTValue : ISample

    {
        public void Run()
        {
            var p1 = new Person {Id = 1, Name = "Name1"};
            var p2 = new Person {Id = 2, Name = "Name2"};
            var p3 = new Person {Id = 3, Name = "Name3"};

            var dict = new Dictionary<int, Person>();
            dict.Add(p1.Id, p1);
            dict.Add(p2.Id, p2);
            dict.Add(p3.Id, p3);

            foreach (var v in dict)
            {
                Console.WriteLine("{0}: {1}", v.Key, v.Value.Name);
            }

            dict[0] = new Person {Id = 4, Name = "Name4"};

            Person result;
            if (!dict.TryGetValue(5, out result))
            {
                Console.WriteLine("No person with a key of 5 can be found");
            }
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}