using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-27 A SqlConnection with a using statement to automatically close it.")]
    internal class ASqlConnectionWithAUsingStatementToAutomaticallyCloseIt : ISample
    {
        public void Run()
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Execute operations against the database
                } // Connection is automatically closed.    
            }
            catch (SqlException)
            {
                Console.WriteLine("Cannot open connection. Does the database exist?");
            }
        }
    }
}