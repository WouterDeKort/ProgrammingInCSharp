using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-35 Inserting values with a parameterized query.")]
    internal class InsertingValuesWithAParameterizedQuery : ISample
    {
        public void Run()
        {
        }

        public async Task InsertRowWithParameterizedQuery()
        {
            string connectionString = ConfigurationManager.
                ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(
                    @"INSERT INTO People([FirstName], [LastName], [MiddleName]) 
                      VALUES(@firstName, @lastName, @middleName)",
                    connection);

                await connection.OpenAsync();

                command.Parameters.AddWithValue("@firstName", "John");
                command.Parameters.AddWithValue("@lastName", "Doe");
                command.Parameters.AddWithValue("@middleName", "Little");

                int numberOfInsertedRows = await command.ExecuteNonQueryAsync();
                Console.WriteLine("Inserted {0} rows", numberOfInsertedRows);
            }
        }
    }
}