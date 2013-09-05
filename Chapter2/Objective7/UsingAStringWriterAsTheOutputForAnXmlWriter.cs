using System.ComponentModel;
using System.IO;
using System.Xml;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-89 Using a StringWriter as the output for an XmlWriter.")]
    internal class UsingAStringWriterAsTheOutputForAnXmlWriter : ISample
    {
        public void Run()
        {
            var stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();
        }
    }
}