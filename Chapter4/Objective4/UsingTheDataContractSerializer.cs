using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using Startup;

namespace Chapter4.Objective4
{
    [Description("Listing 4-78 Using the DataContractSerializer.")]
    internal class UsingTheDataContractSerializer : ISample
    {
        public void Run()
        {
            var p = new PersonDataContract
            {
                Id = 1,
                Name = "John Doe"
            };

            using (Stream stream = new FileStream("data.xml", FileMode.Create))
            {
                var ser = new DataContractSerializer(typeof (PersonDataContract));
                ser.WriteObject(stream, p);
            }

            using (Stream stream = new FileStream("data.xml", FileMode.Open))
            {
                var ser = new DataContractSerializer(typeof (PersonDataContract));
                var result = (PersonDataContract) ser.ReadObject(stream);
            }
        }

        [DataContract]
        public class PersonDataContract
        {
            private bool isDirty = false;

            [DataMember]
            public int Id { get; set; }

            [DataMember]
            public string Name { get; set; }
        }
    }
}