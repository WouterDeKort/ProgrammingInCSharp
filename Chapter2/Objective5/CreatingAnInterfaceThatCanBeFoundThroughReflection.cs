using System.ComponentModel;
using Startup;

namespace Chapter2.Objective5
{
    [Description("Listing 2-69 Creating an interface that can be found through reflection.")]
    internal class CreatingAnInterfaceThatCanBeFoundThroughReflection : ISample
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
    }
}