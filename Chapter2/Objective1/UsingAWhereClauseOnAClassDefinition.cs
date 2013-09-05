using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-14 Using a where clause on a class definition.")]
    internal class UsingAWhereClauseOnAClassDefinition : ISample
    {
        public void Run()
        {
        }

        private class MyClass<T> where T : class, new()
        {
            public MyClass()
            {
                MyProperty = new T();
            }

            private T MyProperty { get; set; }
        }
    }
}