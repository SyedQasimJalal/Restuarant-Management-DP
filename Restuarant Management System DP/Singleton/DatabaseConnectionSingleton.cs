using System;
using System.Data.SqlClient;
using System.Data;

namespace Restaurant_Management_System_DP.Singleton
{
    public class DatabaseConnectionSingleton
    {
        // Static variable to hold the single instance of the class
        private static DatabaseConnectionSingleton _instance = null;

        // Private constructor to prevent instantiation
        private DatabaseConnectionSingleton(string connectionString)
        {
            ConnectionString = connectionString;
        }

        // Public property to access the connection string
        public string ConnectionString { get; private set; }

        // Method to get the single instance of the class
        public static DatabaseConnectionSingleton GetInstance()
        {
            // Check if the instance has been created
            if (_instance == null)
            {
                // Create the instance if it doesn't exist
                _instance = new DatabaseConnectionSingleton(@"Data Source=AAHIL-ALWANI\SQLEXPRESS01;Initial Catalog=RestaurantManagementDB;Integrated Security=True");
            }

            // Return the existing instance
            return _instance;
        }

        // Property to get the SQL connection
        public SqlConnection Connection
        {
            get
            {
                if (connection == null || connection.State != ConnectionState.Open)
                {
                    connection = new SqlConnection(ConnectionString);
                    connection.Open();
                }
                return connection;
            }
        }

        // Private field for the SQL connection
        private SqlConnection connection;
    }
}
