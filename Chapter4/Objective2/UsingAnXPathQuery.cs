using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.XPath;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-46 Using an XPath query.")]
    internal class UsingAnXPathQuery : ISample
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

            var doc = new XmlDocument();
            doc.LoadXml(xml);

            XPathNavigator nav = doc.CreateNavigator();
            string query = "//People/Person[@firstName='Jane']";
            XPathNodeIterator iterator = nav.Select(query);

            Console.WriteLine(iterator.Count); 

            while (iterator.MoveNext())
            {
                string firstName = iterator.Current.GetAttribute("firstName", "");
                string lastName = iterator.Current.GetAttribute("lastName", "");
                Console.WriteLine("Name: {0} {1}", firstName, lastName);
            }
        }
    }
}