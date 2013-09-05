using System.ComponentModel;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-70  Creating a custom plug-in class.")]
    internal class CreatingACustomPlugInClass : ISample
    {
        public void Run()
        {
        }

        public interface IPlugin
        {
            string Name { get; }
            string Description { get; }
            bool Load(MyApplication application);
        }

        public class MyApplication
        {
        }

        public class MyPlugin : IPlugin
        {
            public string Name
            {
                get { return "MyPlugin"; }
            }

            public string Description
            {
                get { return "My Sample Plugin"; }
            }

            public bool Load(MyApplication application)
            {
                return true;
            }
        }
    }
}