using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-77 Covariance with delegates.")]
    internal class CovarianceWithDelegates : ISample
    {
        public delegate TextWriter CovarianceDel();

        public void Run()
        {
            CovarianceDel del;
            del = MethodStream;
            del = MethodString;
        }

        public StreamWriter MethodStream()
        {
            return null;
        }

        public StringWriter MethodString()
        {
            return null;
        }
    }
}