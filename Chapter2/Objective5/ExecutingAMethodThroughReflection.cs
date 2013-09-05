using System.ComponentModel;
using System.Reflection;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-73 Executing a method through reflection.")]
    internal class ExecutingAMethodThroughReflection : ISample

    {
        public void Run()
        {
            int i = 42;
            MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo",
                new[] {typeof (int)});
            var result = (int) compareToMethod.Invoke(i, new object[] {41});
        }
    }
}