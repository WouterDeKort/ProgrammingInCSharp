using System;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-24 Executing an asynchronous HTTP request.")]
    internal class ExecutingAnAsynchronousHTTPRequest : ISample
    {
        public void Run()
        {
            ReadAsyncHttpRequest().Wait();
        }

        public async Task ReadAsyncHttpRequest()
        {
            var client = new HttpClient();
            string result = await client.GetStringAsync("http://www.microsoft.com");

            Console.WriteLine(result);
        }
    }
}