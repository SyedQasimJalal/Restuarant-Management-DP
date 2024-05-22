using Restuarant_Management_System_DP.Singleton;
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
        SqlCommand sqlCommand;

        public bool Authenticate(string username, string password)
        {
            //SqlConnection connection = DatabaseConnectionSingleton.getConnection();
            //sqlCommand = new SqlCommand("",)
            return false;
        }
    }
}
