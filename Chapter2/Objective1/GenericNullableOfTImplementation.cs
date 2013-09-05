using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-13 Generic Nullable<T> implementation.")]
    internal class GenericNullableOfTImplementation : ISample
    {
        public void Run()
        {
        }

        private struct Nullable<T> where T : struct
        {
            private readonly bool hasValue;
            private readonly T value;

            public Nullable(T value)
            {
                hasValue = true;
                this.value = value;
            }

            public bool HasValue
            {
                get { return hasValue; }
            }

            public T Value
            {
                get
                {
                    if (!HasValue) throw new ArgumentException();
                    return value;
                }
            }

            public T GetValueOrDefault()
            {
                return value;
            }
        }
    }
}