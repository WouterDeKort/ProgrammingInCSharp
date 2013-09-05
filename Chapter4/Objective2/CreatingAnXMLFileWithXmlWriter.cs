using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-44 Creating an XML file with XmlWriter.")]
    internal class CreatingAnXMLFileWithXmlWriter : ISample
    {
        public void Run()
        {
            var stream = new StringWriter();

            using (XmlWriter writer = XmlWriter.Create(
                stream,
                new XmlWriterSettings {Indent = true}))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("People");
                writer.WriteStartElement("Person");
                writer.WriteAttributeString("firstName", "John");
                writer.WriteAttributeString("lastName", "Doe");
                writer.WriteStartElement("ContactDetails");
                writer.WriteElementString("EmailAddress", "john@unknown.com");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Flush();
            }

            Console.WriteLine(stream.ToString());
        }
    }
}