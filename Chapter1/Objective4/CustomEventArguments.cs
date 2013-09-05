using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-84 Custom event arguments.")]
    internal class CustomEventArguments : ISample
    {
        public void Run()
        {
            var p = new Pub();

            p.OnChange += (sender, e)
                => Console.WriteLine("Event raised: {0}", e.Value);

            p.Raise();
        }

        public class MyArgs : EventArgs
        {
            public MyArgs(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
        }

        public class Pub
        {
            public event EventHandler<MyArgs> OnChange = delegate { };

            public void Raise()
            {
                OnChange(this, new MyArgs(42));
            }
        }
    }
}