using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;
using Startup;

namespace Chapter4.Objective4
{
    [Description("Listing 4-72 Serializing a derived, complex class to XML.")]
    public class SerializingADerivedComplexClassToXML : ISample
    {
        public void Run()
        {
            var serializer = new XmlSerializer(typeof (Order),
                new[] {typeof (VIPOrder)});
            string xml;
            using (var stringWriter = new StringWriter())
            {
                Order order = CreateOrder();
                serializer.Serialize(stringWriter, order);
                xml = stringWriter.ToString();
            }


            using (var stringReader = new StringReader(xml))
            {
                var o = (Order) serializer.Deserialize(stringReader);
                // Use the order
            }
        }

        private static Order CreateOrder()
        {
            var p1 = new Product {ID = 1, Description = "p2", Price = 9};
            var p2 = new Product {ID = 2, Description = "p3", Price = 6};
            
            Order order = new VIPOrder
            {
                ID = 4,
                Description = "Order for John Doe. Use the nice giftwrap",
                OrderLines = new List<OrderLine>
                {
                    new OrderLine {ID = 5, Amount = 1, Product = p1},
                    new OrderLine {ID = 6, Amount = 10, Product = p2},
                }
            };

            return order;
        }

        [Serializable]
        public class Order
        {
            [XmlAttribute]
            public int ID { get; set; }

            [XmlIgnore]
            public bool IsDirty { get; set; }

            [XmlArray("Lines")]
            [XmlArrayItem("OrderLine")]
            public List<OrderLine> OrderLines { get; set; }
        }

        [Serializable]
        public class OrderLine
        {
            [XmlAttribute]
            public int ID { get; set; }

            [XmlAttribute]
            public int Amount { get; set; }

            [XmlElement("OrderedProduct")]
            public Product Product { get; set; }
        }

        [Serializable]
        public class Product
        {
            [XmlAttribute]
            public int ID { get; set; }

            public decimal Price { get; set; }
            public string Description { get; set; }
        }

        [Serializable]
        public class VIPOrder : Order
        {
            public string Description { get; set; }
        }
    }
}