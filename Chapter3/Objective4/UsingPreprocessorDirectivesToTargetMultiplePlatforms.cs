using System.ComponentModel;
using System.Reflection;
using Startup;

namespace Chapter3.Objective4
{
    [Description("Listing 3-36 Using preprocessor directives to target multiple platforms.")]
    internal class UsingPreprocessorDirectivesToTargetMultiplePlatforms : ISample
    {
        public void Run()
        {
        }

        public Assembly LoadAssembly<T>()
        {
#if !WINRT
            Assembly assembly = typeof (T).Assembly;
#else
        Assembly assembly = typeof(T).GetTypeInfo().Assembly;
#endif

            return assembly;
        }
    }
}