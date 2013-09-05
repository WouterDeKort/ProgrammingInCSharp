using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-82 Using an Action to expose an event.")]
    internal class UsingAnActionToExposeAnEvent : ISample
    {
        public void Run()
        {
            var p = new Pub();
            p.OnChange += () => Console.WriteLine("Event raised to method 1");
            p.OnChange += () => Console.WriteLine("Event raised to method 2");
            p.Raise();
        }

        public class Pub
        {
            public Action OnChange { get; set; }

            public void Raise()
            {
                if (OnChange != null)
                {
                    OnChange();
                }
            }
        }
    }
}