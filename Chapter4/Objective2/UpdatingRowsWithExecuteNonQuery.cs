using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-34 Updating rows with ExecuteNonQuery.")]
    internal class UpdatingRowsWithExecuteNonQuery : ISample
    {
        public void Run()
        {
        }

        public async Task UpdateRows()
        {
            string connectionString = ConfigurationManager.
                ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(
                    "UPDATE People SET FirstName='John'",
                    connection);

                await connection.OpenAsync();
                int numberOfUpdatedRows = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Updated {0} rows", numberOfUpdatedRows);
            }
        }
    }
}