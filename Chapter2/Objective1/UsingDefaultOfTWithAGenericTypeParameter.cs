using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-15 Using default(T) with a generic type parameter.")]
    internal class UsingDefaultOfTWithAGenericTypeParameter : ISample
    {
        public void Run()
        {
            MyGenericMethod<int>();
            MyGenericMethod<string>();
        }

        public void MyGenericMethod<T>()
        {
            T defaultValue = default(T);
        }
    }
}