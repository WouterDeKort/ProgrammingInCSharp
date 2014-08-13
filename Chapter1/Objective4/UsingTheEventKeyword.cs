using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-83 Using the event keyword.")]
    internal class UsingTheEventKeyword : ISample
    {
        public void Run()
        {
            Pub pub = new Pub();

            pub.Raise();
        }
            


        public class Pub
        {
            public event Action OnChange = delegate { };

            public void Raise()
            {
                OnChange();
            }
        }
    }
}