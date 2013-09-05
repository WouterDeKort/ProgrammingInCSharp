using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-26 Executing multiple requests in parallel.")]
    internal class ExecutingMultipleRequestsInParallel : ISample
    {
        public void Run()
        {
        }

        public async Task ExecuteMultipleRequestsInParallel()
        {
            var client = new HttpClient();

            Task microsoft = client.GetStringAsync("http://www.microsoft.com");
            Task msdn = client.GetStringAsync("http://msdn.microsoft.com");
            Task blogs = client.GetStringAsync("http://blogs.msdn.com/");

            await Task.WhenAll(microsoft, msdn, blogs);
        }
    }
}