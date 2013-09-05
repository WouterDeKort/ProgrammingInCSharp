using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-71 Inspecting an assembly for types that implement a custom interface.")]
    internal class InspectingAnAssemblyForTypesThatImplementACustomInterface : ISample
    {
        public void Run()
        {
            Assembly pluginAssembly = typeof (MyPlugin).Assembly;

            IEnumerable<Type> plugins = from type in pluginAssembly.GetTypes()
                where typeof (IPlugin).IsAssignableFrom(type) && !type.IsInterface
                select type;

            foreach (Type pluginType in plugins)
            {
                var plugin = Activator.CreateInstance(pluginType) as IPlugin;
            }
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
            public string Name { get; set; }

            public string Description { get; set; }

            public bool Load(MyApplication application)
            {
                return true;
            }
        }
    }
}