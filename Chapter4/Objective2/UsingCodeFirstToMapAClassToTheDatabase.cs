using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-38 Using Code First to map a class to the database.")]
    internal class UsingCodeFirstToMapAClassToTheDatabase : ISample
    {
        public void Run()
        {
            using (var ctx = new PeopleContext())
            {
                ctx.People.Add(new Person {Id = 1, Name = "John Doe"});
                ctx.SaveChanges();
            }

            using (var ctx = new PeopleContext())
            {
                Person person = ctx.People.SingleOrDefault(p => p.Id == 1);
                Console.WriteLine(person.Name);
            }
        }


        public class PeopleContext : DbContext
        {
            public IDbSet<Person> People { get; set; }
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}