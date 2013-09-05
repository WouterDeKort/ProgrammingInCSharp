using System.ComponentModel;
using System.Data.SqlClient;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-28 Creating a connection string with SqlConnectionStringBuilder.")]
    internal class CreatingAConnectionStringWithSqlConnectionStringBuilder : ISample
    {
        public void Run()
        {
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder();

            sqlConnectionStringBuilder.DataSource = @"(localdb)\v11.0";
            sqlConnectionStringBuilder.InitialCatalog = "ProgrammingInCSharp";

            string connectionString = sqlConnectionStringBuilder.ToString();
        }
    }
}