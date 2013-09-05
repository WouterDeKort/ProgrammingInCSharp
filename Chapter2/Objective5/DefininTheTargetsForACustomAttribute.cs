using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-66 Defining the targets for a custom attribute.")]
    internal class DefininTheTargetsForACustomAttribute : ISample
    {
        public void Run()
        {
        }


        [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
        public class MyMethodAndParameterAttribute : Attribute
        {
        }
    }
}