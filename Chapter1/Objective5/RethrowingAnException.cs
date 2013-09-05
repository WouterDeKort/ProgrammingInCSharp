using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective5
{
    [Description("Listing 1-95 Rethrowing an exception.")]
    internal class RethrowingAnException : ISample
    {
        public void Run()
        {
            try
            {
                SomeOperation();
            }
            catch (Exception logEx)
            {
                Log(logEx);
                throw; // rethrow the original exception
            }
        }

        private void Log(Exception logEx)
        {
        }

        private void SomeOperation()
        {
        }
    }
}