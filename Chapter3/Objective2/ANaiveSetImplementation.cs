using System.Collections.Generic;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective2
{
    [Description("Listing 3-21 A naïve set implementation.")]
    internal class ANaiveSetImplementation : ISample
    {
        public void Run()
        {
        }

        private class Set<T>
        {
            private readonly List<T> list = new List<T>();

            public void Insert(T item)
            {
                if (!Contains(item))
                    list.Add(item);
            }

            public bool Contains(T item)
            {
                foreach (T member in list)
                    if (member.Equals(item))
                        return true;
                return false;
            }
        }
    }
}