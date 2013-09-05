using System.ComponentModel;
using Startup;

namespace Chapter2.Objective4
{
    [Description("Listing 2-42 Adding a set accessor to an implemented interface property.")]
    internal class AddingASetAccessorToAnImplementedInterfaceProperty : ISample
    {
        public void Run()
        {
        }

        private interface IReadOnlyInterface
        {
            int Value { get; }
        }

        private struct ReadAndWriteImplementation : IReadOnlyInterface
        {
            public int Value { get; set; }
        }
    }
}