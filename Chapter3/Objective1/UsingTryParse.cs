using System.ComponentModel;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-5 Using TryParse.")]
    internal class UsingTryParse : ISample
    {
        public void Run()
        {
            string value = "1";
            int result;
            bool success = int.TryParse(value, out result);

            if (success)
            {
                // value is a valid integer, result contains the value
            }
        }
    }
}