using System;
using System.ComponentModel;
using System.IO;
using Startup;

namespace Chapter2.Objective2
{
    [Description("Listing 2-23 Explicitly casting a base type to a derived type.")]
    internal class ExplicitlyCastingABaseTypeToADerivedType : ISample
    {
        public void Run()
        {
            Object stream = new MemoryStream();
            var memoryStream = (MemoryStream) stream;
        }
    }
}