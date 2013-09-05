using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Script.Serialization;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-13 Deserializing an object with the JavaScriptSerializer.")]
    internal class DeserializingAnObjectWithTheJavaScriptSerializer : ISample
    {
        public void Run()
        {
            string json = @"{
                                ""firstName"": ""John"",
                                ""lastName"": ""Smith"",
                                ""age"": 25,
                                ""address"": {
                                    ""streetAddress"": ""21 2nd Street"",
                                    ""city"": ""New York"",
                                    ""state"": ""NY"",
                                    ""postalCode"": ""10021""
                                },
                                ""phoneNumber"": [
                                    {
                                        ""type"": ""home"",
                                        ""number"": ""212 555-1234""
                                    },
                                    {
                                        ""type"": ""fax"",
                                        ""number"": ""646 555-4567""
                                    }
                                ]
                            }";

            var serializer = new JavaScriptSerializer();
            var result = serializer.Deserialize<Dictionary<string, object>>(json);
        }
    }
}