using System;
using System.ComponentModel;
using System.Reflection;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-72 Getting the value of a field through reflection.")]
    internal class GettingTheValueOfAFieldThroughReflection : ISample
    {
        public void Run()
        {
        }

        private static void DumpObject(object obj)
        {
            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo field in fields)
            {
                if (field.FieldType == typeof (int))
                {
                    Console.WriteLine(field.GetValue(obj));
                }
            }
        }
    }
}