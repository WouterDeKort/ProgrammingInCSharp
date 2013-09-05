using System;
using System.ComponentModel;
using System.Security;
using System.Security.Permissions;
using Startup;

namespace Chapter3.Objective2
{
    [Description("Listing 3-26 Imperative CAS.")]
    internal class ImperativeCAS : ISample
    {
        public void Run()
        {
            var f = new FileIOPermission(PermissionState.None);
            f.AllLocalFiles = FileIOPermissionAccess.Read;
            try
            {
                f.Demand();
            }
            catch (SecurityException s)
            {
                Console.WriteLine(s.Message);
            }
        }
    }
}