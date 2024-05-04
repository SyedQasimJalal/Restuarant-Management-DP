using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restuarant_Management_System_DP.Singleton
{
    public class DatabaseConnectionSingleton
    {
        private static SqlConnection connection;

        private DatabaseConnectionSingleton(String connectionString)
        {
            connection= new SqlConnection(connectionString);
        }

        public static DatabaseConnectionSingleton getConnection()
        {
            return new DatabaseConnectionSingleton("Data Source=AAHIL-ALWANI\\SQLEXPRESS01;Initial Catalog=RestaurantManagementDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
