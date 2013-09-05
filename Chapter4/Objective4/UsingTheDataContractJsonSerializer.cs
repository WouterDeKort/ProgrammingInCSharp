using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Startup;

namespace Chapter4.Objective4
{
    [Description("Listing 4-79 Using the DataContractJsonSerializer.")]
    internal class UsingTheDataContractJsonSerializer : ISample
    {
        public void Run()
        {
            var p = new Person
            {
                Id = 1,
                Name = "John Doe"
            };

            using (var stream = new MemoryStream())
            {
                var ser = new DataContractJsonSerializer(typeof (Person));
                ser.WriteObject(stream, p);

                stream.Position = 0;
                var streamReader = new StreamReader(stream);
                Console.WriteLine(streamReader.ReadToEnd()); 

                stream.Position = 0;
                var result = (Person) ser.ReadObject(stream);
            }
        }
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}