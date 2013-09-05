using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective6
{
    [Description("Listing 2-85 Using WeakReference.")]
    internal class UsingWeakReference : ISample
    {
        private static WeakReference data;

        public void Run()
        {
            object result = GetData();
            // GC.Collect(); Uncommenting this line will make data.Target null
            result = GetData();
        }

        private static object GetData()
        {
            if (data == null)
            {
                data = new WeakReference(LoadLargeList());
            }

            if (data.Target == null)
            {
                data.Target = LoadLargeList();
            }
            return data.Target;
        }

        private static object LoadLargeList()
        {
            var bytes = new byte[1024*1024];
            new Random().NextBytes(bytes);
            return bytes;
        }
    }
}