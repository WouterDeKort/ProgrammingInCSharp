using System;
using System.ComponentModel;
using Startup;

namespace Chapter2.Objective7
{
    [Description("Listing 2-99 Implementing custom formatting on a type.")]
    internal class ImplementingCustomFormattingOnAType : ISample
    {
        public void Run()
        {
        }


        private class Person
        {
            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return FirstName + LastName;
            }

            public string ToString(string format)
            {
                if (string.IsNullOrWhiteSpace(format) || format == "G") format = "FL";

                format = format.Trim().ToUpperInvariant();

                switch (format)
                {
                    case "FL":
                        return FirstName + " " + LastName;
                    case "LF":
                        return LastName + " " + FirstName;
                    case "FSL":
                        return FirstName + ", " + LastName;
                    case "LSF":
                        return LastName + ", " + FirstName;
                    default:
                        throw new FormatException(String.Format(
                            "The '{0}' format string is not supported.", format));
                }
            }
        }
    }
}