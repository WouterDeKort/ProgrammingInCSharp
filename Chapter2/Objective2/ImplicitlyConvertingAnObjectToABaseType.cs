using System;
using System.ComponentModel;
using System.Net.Http;
using Startup;

namespace Chapter2.Objective2
{
    [Description("Listing 2-21 Implicitly converting an object to a base type.")]
    internal class ImplicitlyConvertingAnObjectToABaseType : ISample
    {
        public void Run()
        {
            var client = new HttpClient();
            object o = client;
            IDisposable d = client;
        }
    }
}