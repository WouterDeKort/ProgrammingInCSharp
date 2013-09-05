using System.ComponentModel;
using Startup;

namespace Chapter3.Objective4
{
    [Description("Listing 3-38 The line directive.")]
    internal class TheLineDirective : ISample
    {
        public void Run()
        {
#line 200 "OtherFileName"
            int a; // line 200
#line default
            int b; // line 19
#line hidden
            int c; // hidden
            int d; // line 21       
        }
    }
}