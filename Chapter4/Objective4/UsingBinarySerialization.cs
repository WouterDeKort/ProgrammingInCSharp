using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Startup;

namespace Chapter4.Objective4
{
    [Description("Listing 4-73  Using binary serialization.")]
    internal class UsingBinarySerialization : ISample
    {
        public void Run()
        {
            var p = new Person
            {
                Id = 1,
                Name = "John Doe"
            };

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("data.bin", FileMode.Create))
            {
                formatter.Serialize(stream, p);
            }

            using (Stream stream = new FileStream("data.bin", FileMode.Open))
            {
                var dp = (Person) formatter.Deserialize(stream);
            }
        }


        [Serializable]
        public class Person
        {
            private bool isDirty = false;
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}