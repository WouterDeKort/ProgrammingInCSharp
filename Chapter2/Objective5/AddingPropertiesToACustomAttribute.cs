using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-68 Adding properties to a custom attribute.")]
    internal class AddingPropertiesToACustomAttribute : ISample
    {
        public void Run()
        {
        }

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
        private class CompleteCustomAttribute : Attribute
        {
            public CompleteCustomAttribute(string description)
            {
                Description = description;
            }

            public string Description { get; set; }
        }
    }
}