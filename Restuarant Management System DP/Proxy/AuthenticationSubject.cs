using Restaurant_Management_System_DP.Singleton;
using System.Data.SqlClient;

namespace Restuarant_Management_System_DP.Proxy
{
    internal class AuthenticationSubject : IAuthentication
    {
        private DatabaseConnectionSingleton connectionSingleton= DatabaseConnectionSingleton.GetInstance();
        public bool Authenticate(string username, string password)
        {
            SqlConnection connection= connectionSingleton.Connection;
            connection.Open();

            return false;
        }
    }
}
