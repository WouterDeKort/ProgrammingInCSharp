using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-5 Passing a complete customer to a method.")]
    internal class PassingACompleteCustomerToAMethod : ISample
    {
        public void Run()
        {
        }

        public Distance CalculateDistanceTo(Customer customer)
        {
            Distance result = null; // Some difficult calculation that uses customer.Address      
            return result;
        }

        public class Customer
        {
        }

        public class Distance
        {
        }
    }
}