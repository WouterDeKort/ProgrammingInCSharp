using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-41 Using a WCF proxy client.")]
    internal class UsingAWCFProxyClient : ISample
    {
        public void Run()
        {
            // Configure a WCF endpoint to execute the following code

            //MyServiceClient client = new MyServiceClient();
            //string result = client.DoWork("John", "Doe");
            //Console.WriteLine(result);
        }


        [GeneratedCode("System.ServiceModel", "4.0.0.0")]
        [ServiceContract(
            ConfigurationName = "ExternalService.MyService")]
        public interface MyService
        {
            [OperationContract(
                Action = "http://tempuri.org/MyService/DoWork",
                ReplyAction = "http://tempuri.org/MyService/DoWorkResponse")]
            string DoWork(string left, string right);

            [OperationContract(
                Action = "http://tempuri.org/MyService/DoWork",
                ReplyAction = "http://tempuri.org/MyService/DoWorkResponse")]
            Task<string> DoWorkAsync(string left, string right);
        }

        [GeneratedCode("System.ServiceModel", "4.0.0.0")]
        public interface MyServiceChannel : MyService,
            IClientChannel
        {
        }

        [DebuggerStepThrough]
        [GeneratedCode("System.ServiceModel", "4.0.0.0")]
        public class MyServiceClient :
            ClientBase<MyService>,
            MyService
        {
            public MyServiceClient()
            {
            }

            public MyServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
            {
            }

            public MyServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
            {
            }

            public MyServiceClient(string endpointConfigurationName,
                EndpointAddress remoteAddress) :
                    base(endpointConfigurationName, remoteAddress)
            {
            }

            public MyServiceClient(Binding binding,
                EndpointAddress remoteAddress) :
                    base(binding, remoteAddress)
            {
            }

            public string DoWork(string left, string right)
            {
                return base.Channel.DoWork(left, right);
            }

            public Task<string> DoWorkAsync(
                string left,
                string right)
            {
                return base.Channel.DoWorkAsync(left, right);
            }
        }
    }
}