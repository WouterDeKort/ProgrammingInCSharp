using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-7 Using named and optional arguments.")]
    internal class UsingNamedAndOptionalArguments : ISample
    {
        public void Run()
        {
            MyMethod(1, thirdArgument: true);
        }

        private void MyMethod(int firstArgument, string secondArgument = "default value",
            bool thirdArgument = false)
        {
        }
    }
}