using System;
using System.ComponentModel;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-29 Putting a connection string in the app.config file.")]
    internal class PuttingAConnectionStringInTheAppconfigFile : ISample
    {
        public void Run()
        {
            Console.WriteLine(@"?xml version=""1.0"" encoding=""utf-8"" ?>
<configuration>
    <connectionStrings>
        <add name=""ProgrammingInCSharpConnection"" 
     providerName=""System.Data.SqlClient"" 
     connectionString=""Data Source=(localdb)\v11.0;Initial Catalog=ProgrammingInCSharp;""
/>
    </connectionStrings>
</configuration>");
        }
    }
}