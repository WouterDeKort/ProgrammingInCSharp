using System.ComponentModel;
using Startup;

namespace Chapter3.Objective1
{
    [Description("Listing 3-15 A sample XSD file.")]
    internal class ASampleXSDFile : ISample
    {
        public void Run()
        {
            string xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
                            <xs:schema id=""NewDataSet"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" 
                              xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
                              <xs:element name=""Person"">
                                <xs:complexType>
                                  <xs:sequence>
                                    <xs:element name=""FirstName"" type=""xs:string"" minOccurs=""0"" />
                                    <xs:element name=""LastName"" type=""xs:string"" minOccurs=""0"" />
                                    <xs:element name=""Age"" type=""xs:string"" minOccurs=""0"" />
                                  </xs:sequence>
                                </xs:complexType>
                              </xs:element>
                              <xs:element name=""NewDataSet"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">
                                <xs:complexType>
                                  <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">
                                    <xs:element ref=""Person"" />
                                  </xs:choice>
                                </xs:complexType>
                              </xs:element>
                            </xs:schema>";
        }
    }
}