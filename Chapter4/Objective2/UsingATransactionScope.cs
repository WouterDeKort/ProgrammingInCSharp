using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;
using Startup;

namespace Chapter4.Objective2
{
    [Description("Listing 4-36 Using a TransactionScope.")]
    internal class UsingATransactionScope : ISample
    {
        public void Run()
        {
            string connectionString = ConfigurationManager.
                ConnectionStrings["ProgrammingInCSharpConnection"].ConnectionString;

            using (var transactionScope = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var command1 = new SqlCommand(
                        @"INSERT INTO People ([FirstName], [LastName], [MiddleName]) 
                          VALUES('John', 'Doe', null)",
                        connection);

                    var command2 = new SqlCommand(
                        @"INSERT INTO People ([FirstName], [LastName], [MiddleName])
                          VALUES('Jane', 'Doe', null)",
                        connection);

                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                }
                transactionScope.Complete();
            }
        }
    }
}