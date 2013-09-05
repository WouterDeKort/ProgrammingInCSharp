using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;
using Startup;

namespace Chapter4.Objective3
{
    [Description("Listing 4-67 Creating XML with the XElement class.")]
    internal class CreatingXMLWithTheXElementClass : ISample
    {
        public void Run()
        {
            var root = new XElement("Root",
                new List<XElement>
                {
                    new XElement("Child1"),
                    new XElement("Child2"),
                    new XElement("Child3")
                },
                new XAttribute("MyAttribute", 42));

            root.Save("test.xml");
        }
    }
}