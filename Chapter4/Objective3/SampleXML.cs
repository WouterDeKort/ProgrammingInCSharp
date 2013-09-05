using System;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-64 Sample XML.")]
    internal class SampleXML : ISample
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
        }
    }
}