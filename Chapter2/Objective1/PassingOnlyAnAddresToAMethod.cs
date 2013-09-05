using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-6 Passing only an address to a method.")]
    internal class PassingOnlyAnAddresToAMethod : ISample
    {
        public void Run()
        {
        }

        public Distance CalculateDistanceTo(Address address)
        {
            Distance result = null; // Some difficult calculation that uses address     
            return result;
        }

        public class Address
        {
        }

        public class Distance
        {
        }
    }
}