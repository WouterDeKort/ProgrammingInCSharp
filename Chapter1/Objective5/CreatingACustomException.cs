using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Startup;

namespace Chapter1.Objective5
{
    [Description("Listing 1-98  Creating a custom exception.")]
    internal class CreatingACustomException : ISample
    {
        public void Run()
        {
        }

        [Serializable]
        public class OrderProcessingException : Exception, ISerializable
        {
            public OrderProcessingException(int orderId)
            {
                OrderId = orderId;
                HelpLink = "http://www.mydomain.com/infoaboutexception";
            }

            public OrderProcessingException(int orderId, string message)
                : base(message)
            {
                OrderId = orderId;
                HelpLink = "http://www.mydomain.com/infoaboutexception";
            }

            public OrderProcessingException(int orderId, string message,
                Exception innerException)
                : base(message, innerException)
            {
                OrderId = orderId;
                HelpLink = "http://www.mydomain.com/infoaboutexception";
            }

            protected OrderProcessingException(SerializationInfo info, StreamingContext context)
            {
                OrderId = (int) info.GetValue("OrderId", typeof (int));
            }

            public int OrderId { get; private set; }

            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("OrderId", OrderId, typeof (int));
            }
        }
    }
}