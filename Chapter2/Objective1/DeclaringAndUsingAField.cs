using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-9 Declaring and using a field.")]
    internal class DeclaringAndUsingAField : ISample
    {
        public void Run()
        {
            var instance = new MyClass();
            instance.MyInstanceField = "Some New Value";
        }

        public class MyClass
        {
            public string MyInstanceField;

            public string Concatenate(string valueToAppend)
            {
                return MyInstanceField + valueToAppend;
            }
        }
    }
}