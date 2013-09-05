using System.ComponentModel;
using Startup;

namespace Chapter3.Objective4
{
    [Description("Listing 3-37 The warning and error directives.")]
    internal class TheWarningAndErrorDirectives : ISample
    {
        public void Run()
        {
#warning This code is obsolete

#if DEBUG
//#error Debug build is not allowed
#endif
        }
    }
}