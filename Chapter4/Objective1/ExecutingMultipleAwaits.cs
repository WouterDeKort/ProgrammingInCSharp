using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-25 Executing multiple awaits.")]
    internal class ExecutingMultipleAwaits : ISample
    {
        public void Run()
        {
        }

        public async Task ExecuteMultipleRequests()
        {
            var client = new HttpClient();

            string microsoft = await client.GetStringAsync("http://www.microsoft.com");
            string msdn = await client.GetStringAsync("http://msdn.microsoft.com");
            string blogs = await client.GetStringAsync("http://blogs.msdn.com/");
        }
    }
}