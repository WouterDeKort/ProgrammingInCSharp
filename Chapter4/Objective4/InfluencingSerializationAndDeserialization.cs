using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Startup;

namespace Chapter4.Objective4
{
    [Description("Listing 4-75 Influencing serialization and deserialization.")]
    internal class InfluencingSerializationAndDeserialization : ISample
    {
        public void Run()
        {
        }

        [Serializable]
        public class Person
        {
            [NonSerialized] private bool isDirty = false;
            public int Id { get; set; }
            public string Name { get; set; }

            [OnSerializing]
            internal void OnSerializingMethod(StreamingContext context)
            {
                Console.WriteLine("OnSerializing.");
            }

            [OnSerialized]
            internal void OnSerializedMethod(StreamingContext context)
            {
                Console.WriteLine("OnSerialized.");
            }

            [OnDeserializing]
            internal void OnDeserializingMethod(StreamingContext context)
            {
                Console.WriteLine("OnDeserializing.");
            }

            [OnDeserialized]
            internal void OnDeserializedMethod(StreamingContext context)
            {
                Console.WriteLine("OnSerialized.");
            }
        }
    }
}