using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-61 Seeing whether an attribute is defined.")]
    internal class SeeingWhetherAnAttributeIsDefined : ISample
    {
        public void Run()
        {
            if (Attribute.IsDefined(typeof (Person), typeof (SerializableAttribute)))
            {
                Console.WriteLine("Person is serializable");
            }
        }

        [Serializable]
        private class Person
        {
        }
    }
}