using System;
using System.ComponentModel;
using Startup;

namespace Chapter1.Objective4
{
    [Description("Listing 1-85 Custom event accessor.")]
    internal class CustomEeventAccessor : ISample
    {
        public void Run()
        {
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
            private event EventHandler<MyArgs> onChange = delegate { };

            public event EventHandler<MyArgs> OnChange
            {
                add
                {
                    lock (onChange)
                    {
                        onChange += value;
                    }
                }
                remove
                {
                    lock (onChange)
                    {
                        onChange -= value;
                    }
                }
            }

            public void Raise()
            {
                onChange(this, new MyArgs(42));
            }
        }
    }
}