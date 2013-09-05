using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using Startup;

namespace Chapter4.Objective4
{
    [Description("Listing 4-70 Serializing an object with the XmlSerializer.")]
    public class SerializingAnObjectWithTheXmlSerializer : ISample
    {
        public void Run()
        {
            var serializer = new XmlSerializer(typeof (Person));
            string xml;
            using (var stringWriter = new StringWriter())
            {
                var p = new Person
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 42
                };
                serializer.Serialize(stringWriter, p);
                xml = stringWriter.ToString();
            }

            Console.WriteLine(xml);

            using (var stringReader = new StringReader(xml))
            {
                var p = (Person) serializer.Deserialize(stringReader);
                Console.WriteLine("{0} {1} is {2} years old", p.FirstName, p.LastName, p.Age);
            }
        }

        [Serializable]
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
    }
}