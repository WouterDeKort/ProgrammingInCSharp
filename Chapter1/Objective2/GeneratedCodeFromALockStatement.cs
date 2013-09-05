using System.ComponentModel;
using System.Threading;
using Startup;

namespace Chapter1.Objective2
{
    [Description("Listing 1-38 Generated code from a lock statement.")]
    internal class GeneratedCodeFromALockStatement : ISample
    {
        public void Run()
        {
            var gate = new object();
            bool __lockTaken = false;
            try
            {
                Monitor.Enter(gate, ref __lockTaken);
            }
            finally
            {
                if (__lockTaken)
                    Monitor.Exit(gate);
            }
        }
    }
}