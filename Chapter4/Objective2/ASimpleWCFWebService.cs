using System.ComponentModel;
using System.ServiceModel;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-39 A simple WCF web service.")]
    internal class ASimpleWCFWebService : ISample
    {
        public void Run()
        {
        }

        [ServiceContract]
        public class MyService
        {
            [OperationContract]
            public string DoWork(string left, string right)
            {
                return left + right;
            }
        }
    }
}