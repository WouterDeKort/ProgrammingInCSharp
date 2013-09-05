using System;
using System.ComponentModel;
using Startup;

namespace Chapter3.Objective3
{
    [Description("Listing 3-30 Redirecting assembly bindings to a newer version.")]
    internal class RedirectinAssemblyBindingsToANewerVersion : ISample
    {
        public void Run()
        {
            Console.WriteLine(@"
<configuration>
   <runtime>
      <assemblyBinding xmlns=""urn:schemas-microsoft-com:asm.v1"">
       <dependentAssembly>
         <assemblyIdentity name=""myAssembly""
                           publicKeyToken=""32ab4ba45e0a69a1""
                           culture=""en-us"" />
         <!-- Redirecting to version 2.0.0.0 of the assembly. -->
         <bindingRedirect oldVersion=""1.0.0.0""
                          newVersion=""2.0.0.0""/>
       </dependentAssembly>
      </assemblyBinding>
   </runtime>
</configuration>");
        }
    }
}