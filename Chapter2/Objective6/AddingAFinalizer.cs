using System.ComponentModel;
using Startup;

namespace Chapter2.Objective6
{
    [Description("Listing 2-79 Adding a finalizer.")]
    internal class AddingAFinalizer : ISample
    {
        public void Run()
        {
        }

        public class SomeType
        {
            ~SomeType()
            {
                // This code is called when the finalize method executes
            }
        }
    }
}