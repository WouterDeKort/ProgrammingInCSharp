using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-62 Getting a specific attribute instance.")]
    internal class GettingASpecificAttributeInstance : ISample
    {
        public void Run()
        {
            MemberInfo memberInfo = typeof (GettingASpecificAttributeInstance).GetMethod("MyMethod",
                BindingFlags.NonPublic | BindingFlags.Static);

            var conditionalAttribute =
                (ConditionalAttribute) Attribute.GetCustomAttributes(
                    memberInfo,
                    typeof (ConditionalAttribute))[0];
            string condition = conditionalAttribute.ConditionString;

            Console.WriteLine(condition);
        }

        [Conditional("CONDITION1"), Conditional("CONDITION2")]
        private static void MyMethod()
        {
        }
    }
}