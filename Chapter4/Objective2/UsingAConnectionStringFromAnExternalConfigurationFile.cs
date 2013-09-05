using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-30 Using a connection string from an external configuration file.")]
    internal class UsingAConnectionStringFromAnExternalConfigurationFile : ISample
    {
        public void Run()
        {
            string connectionString = ConfigurationManager.
                ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }
    }
}