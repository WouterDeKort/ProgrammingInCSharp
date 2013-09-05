using System.ComponentModel;
using System.IO;
using System.Security.AccessControl;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-4 Setting access control for a directory.")]
    internal class SettingAccessControlForADirectory : ISample
    {
        public void Run()
        {
            var directoryInfo = new DirectoryInfo("TestDirectory");
            directoryInfo.Create();
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(
                new FileSystemAccessRule("everyone",
                    FileSystemRights.ReadAndExecute,
                    AccessControlType.Allow));
            directoryInfo.SetAccessControl(directorySecurity);
        }
    }
}