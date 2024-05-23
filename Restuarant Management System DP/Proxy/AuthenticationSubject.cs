using Restaurant_Management_System_DP.Singleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restuarant_Management_System_DP.Proxy
{
    internal class AuthenticationSubject : IAuthentication
    {
        private SqlConnection connection = DatabaseConnectionSingleton.GetInstance().Connection;
        private SqlCommand command;

        public bool Authenticate(string email, string password)
        {
            //connection.Open();

            command = new SqlCommand("select count(*) from customer where email='"+email+"' and password='"+password+"'", connection);
            int result= (int)command.ExecuteScalar();
            return result>0;
        }
    }
}
