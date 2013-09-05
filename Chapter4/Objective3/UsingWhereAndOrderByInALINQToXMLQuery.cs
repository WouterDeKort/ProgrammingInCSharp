using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-66 Using Where and OrderBy in a LINQ to XML query.")]
    internal class UsingWhereAndOrderByInALINQToXMLQuery : ISample
    {
        public void Run()
        {
            String xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
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
                where p.Descendants("PhoneNumber").Any()
                let name = (string) p.Attribute("firstName")
                           + " " + (string) p.Attribute("lastName")
                orderby name
                select name;
        }
    }
}