using System.ComponentModel;
using System.Runtime.Serialization;
using Startup;

namespace Chapter4.Objective4
{
    [Description("Listing 4-77 Using a DataContract.")]
    internal class UsingADataContract : ISample
    {
        public void Run()
        {
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