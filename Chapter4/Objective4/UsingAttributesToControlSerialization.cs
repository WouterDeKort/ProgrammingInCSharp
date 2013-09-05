using System;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective4
{
    [Description("Listing 4-74 Using attributes to control serialization.")]
    internal class UsingAttributesToControlSerialization : ISample
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
        }
    }
}