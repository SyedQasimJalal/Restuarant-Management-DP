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
        private SqlDataAdapter adapter;

        public bool Authenticate(string email, string password)
        {
            connection.Open();

            adapter = new SqlDataAdapter("select email, password from customer where email='"+email+"' and password='"+password+"'", connection);
            //SqlDataReader reader= new SqlDataReader("");


            //if(res>0)
            //{
            //    return true;
            //}
            return false;
        }
    }
}
