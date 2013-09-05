using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Startup;

namespace Chapter4.Objective4
{
    [Description("Listing 4-76 Implementing ISerializable.")]
    internal class ImplementingISerializable : ISample
    {
        public void Run()
        {
        }

        [Serializable]
        public class PersonComplex : ISerializable
        {
            private readonly bool isDirty;

            public PersonComplex()
            {
            }

            protected PersonComplex(SerializationInfo info, StreamingContext context)
            {
                Id = info.GetInt32("Value1");
                Name = info.GetString("Value2");
                isDirty = info.GetBoolean("Value3");
            }

            public int Id { get; set; }
            public string Name { get; set; }

            [SecurityPermission(SecurityAction.Demand,
                SerializationFormatter = true)]
            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("Value1", Id);
                info.AddValue("Value2", Name);
                info.AddValue("Value3", isDirty);
            }
        }
    }
}