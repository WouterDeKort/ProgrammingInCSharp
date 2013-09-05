using System;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective3
{
    [Description("Listing 3-32 Specifying additional locations for assemblies.")]
    internal class SpecifyinAdditionalLocationsForAssemblies : ISample
    {
        public void Run()
        {
            Console.WriteLine(@");
<?xml version=""1.0"" encoding=""utf-8"" ?>
<configuration>
  <runtime>
    <assemblyBinding xmlns=""urn:schemas-microsoft-com:asm.v1"">
      <dependentAssembly>
        <codeBase version=""1.0.0.0""
          href=""http://www.mydomain.com/ReferencedAssembly.dll""/>
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
</configuration>");
        }
    }
}