using System;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective3
{
    [Description("Listing 3-31 Specifying additional locations for assemblies.")]
    internal class SpecifyingAdditionalLocationsForAssemblies : ISample
    {
        public void Run()
        {
            Console.WriteLine(@"<?xml version=""1.0"" encoding=""utf-8"" ?>
<configuration>
  <runtime>
    <assemblyBinding xmlns=""urn:schemas-microsoft-com:asm.v1"">
      <probing privatePath=""MyLibraries""/>
    </assemblyBinding>
  </runtime>
</configuration>");
        }
    }
}