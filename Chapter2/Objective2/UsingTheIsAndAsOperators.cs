using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using Startup;

namespace Chapter2.Objective2
{
    [Description("Listing 2-27 Using the is and as operators.")]
    internal class UsingTheIsAndAsOperators : ISample

    {
        public void Run()
        {
        }

        private void OpenConnection(DbConnection connection)
        {
            if (connection is SqlConnection)
            {
                // run some special code     
            }
        }

        private void LogStream(Stream stream)
        {
            var memoryStream = stream as MemoryStream;
            if (memoryStream != null)
            {
                // ....     
            }
        }
    }
}