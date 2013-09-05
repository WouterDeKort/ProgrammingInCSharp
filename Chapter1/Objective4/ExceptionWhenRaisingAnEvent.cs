using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-86 Exception when raising an event.")]
    internal class ExceptionWhenRaisingAnEvent : ISample
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


            p.Raise();
        }

        public class Pub
        {
            public event EventHandler OnChange = delegate { };

            public void Raise()
            {
                OnChange(this, EventArgs.Empty);
            }
        }
    }
}