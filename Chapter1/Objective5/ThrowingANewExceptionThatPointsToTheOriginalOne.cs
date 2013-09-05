using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Startup;

namespace Chapter1.Objective5
{
    [Description("Listing 1-96 Throwing a new exception that points to the original one.")]
    internal class ThrowingANewExceptionThatPointsToTheOriginalOne : ISample
    {
        public void Run()
        {
            try
            {
                try
                {
                    ProcessOrder();
                }
                catch (MessageQueueException ex)
                {
                    throw new OrderProcessingException(1, "Error while processing order", ex);
                }
            }
            catch (OrderProcessingException ex)
            {
                Console.WriteLine("Exception handled");
            }
        }

        private void ProcessOrder()
        {
            throw new MessageQueueException();
        }

        // Placeholder class for code
        private class MessageQueueException : Exception
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

            public override void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("OrderId", OrderId, typeof (int));
            }
        }
    }
}