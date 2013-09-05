using System.ComponentModel;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-14 A sample XML with person data.")]
    internal class ASampleXMLWithPersonData : ISample
    {
        private string sampleXml =
            @"<?xml version=""1.0"" encoding=""utf-16"" ?>
                    <Person xmlns:xsi=""http://www.w3.org/2001/XMLSchema-           
                            instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
                      <FirstName>John</FirstName>
                      <LastName>Doe</LastName>
                      <Age>42</Age>
                    </Person>";

        public void Run()
        {
        }
    }
}