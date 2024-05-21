using Restaurant_Management_System_DP.Singleton;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Adapter
{
    internal class SqlServerDatabaseAdapter : IDatabaseAdapter
    {
        private DatabaseConnectionSingleton databaseConnection= DatabaseConnectionSingleton.GetInstance();
        private SqlConnection connection;

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public DataTable ExecuteQuery(string query)
        {

            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }
    }
}
