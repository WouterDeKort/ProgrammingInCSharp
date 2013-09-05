using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-87 Manually raising events with exception handling.")]
    internal class ManuallyRaisingEventsWithExceptionHandling : ISample
    {
        public void Run()
        {
        }

        public void CreateAndRaise()
        {
            var p = new Pub();

            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 1 called");

            p.OnChange += (sender, e)
                => { throw new Exception(); };

            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 3 called");

            try
            {
                p.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions.Count);
            }
        }

        public class Pub
        {
            public event EventHandler OnChange = delegate { };

            public void Raise()
            {
                var exceptions = new List<Exception>();

                foreach (Delegate handler in OnChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, EventArgs.Empty);
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }

                if (exceptions.Any())
                {
                    throw new AggregateException(exceptions);
                }
            }
        }
    }
}