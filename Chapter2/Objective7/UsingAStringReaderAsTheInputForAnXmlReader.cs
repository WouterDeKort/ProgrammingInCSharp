using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Xml;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-90 Using a StringReader as the input for an XmlReader.")]
    internal class UsingAStringReaderAsTheInputForAnXmlReader : ISample
    {
        public void Run()
        {
            string xml = @"<?xml version=""1.0"" encoding=""utf-16""?>
    <book>
        <price>19.95</price>
    </book>";
            var stringReader = new StringReader(xml);
            using (XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(),
                    new CultureInfo("en-US")); // Make sure that you read the decimal part correctly
            }
        }
    }
}