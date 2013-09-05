using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-65 Querying some XML by using LINQ to XML.")]
    internal class QueryingSomeXMLByUsingLINQToXML : ISample
    {
        public void Run()
        {
            string xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                    <people>
                      <person firstname=""john"" lastname=""doe"">
                        <contactdetails>
                          <emailaddress>john@unknown.com</emailaddress>
                        </contactdetails>
                      </person>
                      <person firstname=""jane"" lastname=""doe"">
                        <contactdetails>
                          <emailaddress>jane@unknown.com</emailaddress>
                          <phonenumber>001122334455</phonenumber>
                        </contactdetails>
                      </person>
                    </people>";

            XDocument doc = XDocument.Parse(xml);
            IEnumerable<string> personNames = from p in doc.Descendants("Person")
                select (string) p.Attribute("firstName")
                       + " " + (string) p.Attribute("lastName");
            foreach (string s in personNames)
            {
                Console.WriteLine(s);
            }
        }
    }
}