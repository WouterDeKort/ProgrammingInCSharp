using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-67 Setting the AllowMultiple parameter for a custom attribute.")]
    internal class SettingTheAllowMultipleParameterForACustomAttribute : ISample
    {
        public void Run()
        {
        }

        [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
        private class MyMultipleUsageAttribute : Attribute
        {
        }
    }
}