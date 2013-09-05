using System;
using System.ComponentModel;
using System.Dynamic;
using Startup;

namespace Chapter2.Objective2
{
    [Description("Listing 2-29 Creating a custom DynamicObject.")]
    internal class CreatingACustomDynamicObject : ISample
    {
        public void Run()
        {
            dynamic obj = new SampleObject();
            Console.WriteLine(obj.SomeProperty);
        }

        public class SampleObject : DynamicObject
        {
            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                result = binder.Name;
                return true;
            }
        }
    }
}