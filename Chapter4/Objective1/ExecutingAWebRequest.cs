using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using Startup;

namespace Chapter4.Objective1
{
    [Description("Listing 4-22 Executing a web request.")]
    internal class ExecutingAWebRequest : ISample
    {
        public void Run()
        {
            WebRequest request = WebRequest.Create("http://www.microsoft.com");
            using (WebResponse response = request.GetResponse())
            {

                using (var responseStream = new StreamReader(response.GetResponseStream()))
                {
                    string responseText = responseStream.ReadToEnd();
                    Console.WriteLine(responseText);
                }
            }
        }
    }
}