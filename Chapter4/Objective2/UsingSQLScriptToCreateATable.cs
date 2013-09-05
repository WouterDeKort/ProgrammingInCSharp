using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-31 Using SQL script to create a table.")]
    internal class UsingSQLScriptToCreateATable : ISample
    {
        public void Run()
        {
            string sql = @"CREATE TABLE dbo.People
(
  [id]     INT         NOT NULL IDENTITY,
  [FirstName] VARCHAR(30) NOT NULL,
  [MiddleName] VARCHAR(30) NULL,
  [LastName]  VARCHAR(30) NOT NULL
);        ";

            using (
                var connection =
                    new SqlConnection(
                        ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(sql, connection);

                command.ExecuteNonQuery();
            }
        }
    }
}