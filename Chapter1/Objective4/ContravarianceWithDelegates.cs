using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-78 Contravariance with delegates.")]
    internal class ContravarianceWithDelegates : ISample
    {
        public delegate void ContravarianceDel(StreamWriter tw);

        public void Run()
        {
            ContravarianceDel del = DoSomething;
        }

        private void DoSomething(TextWriter tw)
        {
        }
    }
}