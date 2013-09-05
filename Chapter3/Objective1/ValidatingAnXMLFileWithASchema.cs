using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Schema;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-16 Validating an XML file with a schema.")]
    internal class ValidatingAnXMLFileWithASchema : ISample
    {
        public void Run()
        {
        }

        public void ValidateXML()
        {
            string xsdPath = "person.xsd";
            string xmlPath = "person.xml";

            XmlReader reader = XmlReader.Create(xmlPath);
            var document = new XmlDocument();
            document.Schemas.Add("", xsdPath);
            document.Load(reader);

            ValidationEventHandler eventHandler =
                ValidationEventHandler;
            document.Validate(eventHandler);
        }

        private static void ValidationEventHandler(object sender,
            ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);
                    break;
            }
        }
    }
}