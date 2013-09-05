using System;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-47 A sample JSON file.")]
    internal class ASampleJSONFile : ISample
    {
        public void Run()
        {
            Console.WriteLine(@"
{
 ""People"": {
    ""Person"": [
      {
        ""firstName"": ""John"",
        ""lastName"": ""Doe"",
        ""ContactDetails"": { ""EmailAddress"": ""john@unknown.com"" }
      },
      {
        ""firstName"": ""Jane"",
        ""lastName"": ""Doe"",
        ""ContactDetails"": {
          ""EmailAddress"": ""jane@unknown.com"",
          ""PhoneNumber"": ""001122334455""
        }
      }
    ]
  }");
        }
    }
}