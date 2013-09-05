using System;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-42 XML file.")]
    internal class XMLFile : ISample
    {
        public void Run()
        {
            string xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
<people>
  <person firstName=""John"" lastName=""Doe"">
    <contactdetails>
      <emailaddress>john@unknown.com</emailaddress>
    </contactdetails>
  </person>
  <person firstName=""Jane"" lastName=""Doe"">
    <contactdetails>
      <emailaddress>jane@unknown.com</emailaddress>
      <phonenumber>001122334455</phonenumber>
    </contactdetails>
  </person>
</people>";
            Console.WriteLine(xml);
        }
    }
}