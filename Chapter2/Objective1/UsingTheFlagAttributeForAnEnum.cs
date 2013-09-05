using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective1
{
    [Description("Listing 2-1 Using the FlagAttribute for an enum.")]
    internal class UsingTheFlagAttributeForAnEnum : ISample
    {
        public void Run()
        {
            Days readingDays = Days.Monday | Days.Saturday;
        }

        [Flags]
        private enum Days
        {
            None = 0x0,
            Sunday = 0x1,
            Monday = 0x2,
            Tuesday = 0x4,
            Wednesday = 0x8,
            Thursday = 0x10,
            Friday = 0x20,
            Saturday = 0x40
        }
    }
}