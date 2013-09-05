using System.ComponentModel;
using System.Security.Permissions;
using Startup;

namespace Chapter3.Objective2
{
    [Description("Listing 3-25 Declarative CAS.")]
    internal class DeclarativeCASSample : ISample
    {
        public void Run()
        {
        }

        [FileIOPermission(SecurityAction.Demand,
            AllLocalFiles = FileIOPermissionAccess.Read)]
        public void DeclarativeCAS()
        {
            // Method body
        }
    }
}