using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-8 Returning data from a method.")]
    internal class ReturningDataFromAMethod : ISample
    {
        public void Run()
        {
        }

        public void MethodWithoutAnyReturnValue()
        {
            /* Don’t return any value to the caller */
        }

        public int MethodWithReturnValue()
        {
            return 42;
        }
    }
}